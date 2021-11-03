﻿using Capa_Logica;
using Capa_Logica.Clases;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Formularios.Servicios
{
    public partial class frmRegServicios : Form
    {
        private Validaciones validar = new Validaciones();

        private List<Capa_Entidades.Servicios> servicios;

        public frmRegServicios()
        {
            InitializeComponent();
        }

        #region Eventos del Form
        private void frmRegServicios_Load(object sender, EventArgs e)
        {
            //Instancio la Clase
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            //Guardo los servicios que traje en un List<>
            servicios = metodos.traerServicios();

            //Si no es null(Osea que los trajo exitosamente)
            if (servicios != null)
            {
                //Los Cargo en el DGV
                foreach (Capa_Entidades.Servicios s in servicios)
                {
                    //Agrego los servicios al CMB y al DGV
                    String cantidad = s.Cantidad == 0 ? "---" : s.Cantidad.ToString();
                    dgvServicios.Rows.Add(s.Nombre, s.Duracion, cantidad, s.Precio);
                    cmbServicio.Items.Add(s.Nombre);
                }

                //Para que los CMB empienzen en algun elemento
                cmbServicio.SelectedIndex = 0;
                cmbFormaDePago.SelectedIndex = 0;

                //Para que el servicio no pueda tener un inicio anterir a la fecha actual
                dtpInicioServicio.MinDate = DateTime.Now;

                //Logo del ErrorProvider
                errorProvider.Icon = Properties.Resources.ErrorProvider;
            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error al cargar los servicios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

                //Dehabilito todo menos el boton de salir
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                panel1.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            if (validaciones.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacios ¿Quieres cerrar igual?", "Cerrar"))
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        #endregion

        //Descartar Servicio
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedulaTitular, dtpFechaInico, cmbServicio, cmbFormaDePago };

                //No lo hago con el metodo porque necesito la fecha actual
                dtpInicioServicio.MinDate = DateTime.Now;
                dtpInicioServicio.Value = DateTime.Now;

                validar.limpiarControles(controles);

                //Y borro el error provider
                errorProvider.Clear();
            }
        }

        //Registrar Servicio
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Valido que la cedula sea correcta
            if (ValidarPersona.ValidarCedula(txtCedulaTitular, errorProvider))
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Busco si existe un cliente con esa cedula
                int retorno = metodos.buscarCliente(Convert.ToInt32(txtCedulaTitular.Text));

                //Si exieste
                if (retorno >= 1)
                {
                    //Creo un Objeto Reserva con los datos que necesito para validar que exista
                    Reserva reserva = new Reserva();
                    
                    //Le asigno los valores
                    reserva.Ci = Convert.ToInt32(txtCedulaTitular.Text);
                    reserva.Inicio = dtpFechaInico.Value;

                    //Valido si la reserva existe
                    retorno = metodos.buscarIdDeReservaConfirmada(reserva);
                    if (retorno > 0)
                    {
                        //Creo este objeto para validar
                        Validaciones fechas = new Validaciones();

                        //Valido que la fecha de inicio del servico no ocurra antes que el inicio de la reserva al cual se le asgina
                        retorno = metodos.validarFechaServicio(reserva, dtpInicioServicio.Value);
                        if (retorno == 1)
                        {
                            retorno = metodos.servicioYaExiste(servicios[cmbServicio.SelectedIndex].Nombre, dtpInicioServicio.Value, reserva.Ci);
                            if(retorno == 0)
                            {
                                //Compruebo que los cupos del servicio no esten llenos
                                retorno = metodos.validarMaxCantidadServicio(servicios[cmbServicio.SelectedIndex], dtpInicioServicio.Value, servicios[cmbServicio.SelectedIndex].Nombre);
                                if (retorno == 1)
                                {
                                    if (Mensaje.MostraPreguntaSiNo("¿Quiere dar del alta el servicio " + cmbServicio.SelectedItem.ToString() + " para la reserva del cliente " + txtCedulaTitular.Text + " " +
                                                                           "en la fecha " + dtpFechaInico.Value.ToShortDateString() + "?", "Alta Reserva"))
                                    {
                                        //Intendo dar de Alta el Servicio
                                        retorno = metodos.altaServicio(Convert.ToInt32(txtCedulaTitular.Text), servicios[cmbServicio.SelectedIndex], dtpFechaInico.Value, dtpInicioServicio.Value, cmbFormaDePago.SelectedItem.ToString());
                                        if (retorno > 0)
                                        {
                                            Mensaje.MostrarInfo("Alta de Servicio exitosa", "Alta exitosa");
                                        }
                                        else
                                        {
                                            Mensaje.MostrarError("Ocurrio un error al dar de alta el Servicio", Mensaje.ErrorBD);
                                        }
                                    }
                                }
                                else if (retorno == 1)
                                {
                                    DateTime fin = dtpInicioServicio.Value + servicios[cmbServicio.SelectedIndex].Duracion;
                                    Mensaje.MostrarError("Este servicio en el horario " + dtpInicioServicio.Value.ToShortDateString() + " a " + fin.ToShortDateString() +
                                        "ya esta lleno, eliga otro horario", Mensaje.ErrorIngreso);
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrio un error al comprobar la cantidad maxima del servicio", Mensaje.ErrorBD);
                                }
                            }
                            else if(retorno == 1)
                            {
                                Mensaje.MostrarError("El Cliente ya tiene ese servicio regitrado con ese inicio, marque otro horario", Mensaje.ErrorIngreso);
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrio un error al comprobar si ya existe el servicio", Mensaje.ErrorBD);
                            }
                        }
                        else if(retorno == -2)
                        {
                            Mensaje.MostrarError("La fecha de registro del servicio no se encuentra dentro de esa reserva", Mensaje.ErrorIngreso);
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrio un error al comprobar las fechas del servicio", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarError("El Cliente ingresado no tiene una reserva confirmada con inicio para " + dtpFechaInico.Value.ToString("dd/MM/yyyy"), Mensaje.ErrorIngreso);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrio un error al buscar la Reserva", Mensaje.ErrorBD);
                    }
                }
                else if (retorno == 0)
                {
                    Mensaje.MostrarInfo("El Cliente ingresado no existe", "Aviso en alta Servicio");
                }
                else
                {
                    Mensaje.MostrarError("Ocurrio un error al buscar el Cliente", Mensaje.ErrorBD);
                }
            }
        }

        #region Validaciones de Ingreso
        //Cedula
        private void txtCedulaTitular_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtCedulaTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }
        #endregion
    }
}
