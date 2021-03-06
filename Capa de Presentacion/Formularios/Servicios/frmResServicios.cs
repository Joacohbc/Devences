using Capa_Logica;
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
    public partial class frmResServicios : Form
    {
        private Validaciones validar = new Validaciones();

        private List<Capa_Entidades.Servicios> servicios;

        public frmResServicios()
        {
            InitializeComponent();
            errorProvider.Icon = Properties.Resources.IconoError;
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
                errorProvider.Icon = Properties.Resources.IconoError;
            }
            else
            {
                Mensaje.MostrarError("Ocurrió un error al cargar los servicios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

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
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacíos, ¿Quieres cerrar igual?", "Cerrar"))
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

        //Descartar Servicio
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere vaciar los campos?", "Vaciar los campos"))
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
                //Creo objeto para usar los metodos de BBDD
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Creo un objeto servicio con el servicio seleccionado
                Capa_Entidades.Servicios servicioSeleccionado = servicios[cmbServicio.SelectedIndex];

                //Busco si existe un cliente con esa cedula
                int retorno = metodos.buscarCliente(Convert.ToInt32(txtCedulaTitular.Text));

                //Si existe el cliente
                if (retorno >= 1)
                {
                    //Valido si la reserva existe
                    retorno = metodos.buscarIdDeReservaConfirmada(Convert.ToInt32(txtCedulaTitular.Text), dtpFechaInico.Value);

                    //Si la reserva existe
                    if (retorno > 0)
                    {
                        //Creo un Objeto Reserva
                        Reserva reserva = metodos.traerReserva(Convert.ToInt32(txtCedulaTitular.Text), dtpFechaInico.Value);

                        if(reserva != null)
                        { 
                            if(reserva.Ci != -1)
                            {
                                //Valido que el servicio este dentro de los horarios del SPA
                                retorno = metodos.estaDentroDeHorarios(dtpInicioServicio.Value, (dtpInicioServicio.Value + servicioSeleccionado.Duracion));
                                if (retorno == 1)
                                {
                                    //Creo este objeto para validar
                                    Validaciones fechas = new Validaciones();

                                    //Valido que la fecha de inicio del servico no ocurra antes que el inicio de la reserva al cual se le asgina
                                    retorno = metodos.validarFechaServicio(reserva, dtpInicioServicio.Value);
                                    if (retorno == 1)
                                    {
                                        retorno = metodos.servicioYaExiste(servicioSeleccionado.Nombre, reserva.Ci);
                                        if (retorno == 0)
                                        {
                                            //Compruebo que los cupos del servicio no esten llenos
                                            retorno = metodos.validarMaxCantidadServicio(servicioSeleccionado, dtpInicioServicio.Value);
                                            if (retorno == 1)
                                            {
                                                if (Mensaje.MostraPreguntaSiNo("¿Quiere dar de alta el servicio " + servicioSeleccionado.Nombre + " para la reserva del cliente " + reserva.Ci + " " +
                                                                                       "en la fecha " + dtpFechaInico.Value.ToShortDateString() + "?", "Alta de Servicio"))
                                                {
                                                    //Intendo dar de Alta el Servicio
                                                    retorno = metodos.altaServicio(reserva.Ci, servicioSeleccionado, reserva.Inicio, dtpInicioServicio.Value, cmbFormaDePago.SelectedItem.ToString());
                                                    if (retorno > 0)
                                                    {
                                                        retorno = metodos.modificarPrecioEnReserva(servicioSeleccionado.Precio, reserva.Id);
                                                        if(retorno > 0)
                                                        {
                                                            Mensaje.MostrarInfo("Alta de Servicio exitosa", "Alta exitosa");
                                                        }
                                                        else
                                                        {
                                                            Mensaje.MostrarError("Ocurrió un error al agregar el precio del servicio a la reserva, pero el servicio se reservó con éxito", Mensaje.ErrorBD);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Mensaje.MostrarError("Ocurrió un error al dar de alta el Servicio", Mensaje.ErrorBD);
                                                    }
                                                }
                                            }
                                            else if (retorno == 0)
                                            {
                                                DateTime fin = dtpInicioServicio.Value + servicioSeleccionado.Duracion;
                                                Mensaje.MostrarError("Este servicio en el horario de " + dtpInicioServicio.Value.ToLongTimeString() + " a " + fin.ToLongTimeString() +
                                                    " ya está lleno, elija otro horario", Mensaje.ErrorIngreso);
                                            }
                                            else
                                            {
                                                Mensaje.MostrarError("Ocurrió un error al comprobar la cantidad máxima del servicio", Mensaje.ErrorBD);
                                            }
                                        }
                                        else if (retorno == 1)
                                        {
                                            Mensaje.MostrarError("El Cliente ya tiene ese servicio reservado, espere a que termine o delo de baja", Mensaje.ErrorIngreso);
                                        }
                                        else
                                        {
                                            Mensaje.MostrarError("Ocurrió un error al comprobar si ya se encuentra reservado el servicio", Mensaje.ErrorBD);
                                        }
                                    }
                                    else if (retorno == -2)
                                    {
                                        Mensaje.MostrarError("La fecha en la que se quiere reservar el servicio no se encuentra dentro del período de la reserva", Mensaje.ErrorIngreso);
                                    }
                                    else
                                    {
                                        Mensaje.MostrarError("Ocurrió un error al comprobar las fechas del servicio", Mensaje.ErrorBD);
                                    }
                                }
                                else if (retorno == 0)
                                {
                                    Mensaje.MostrarError("La fecha en la que se quiere reservar el servicio no se encuentra dentro del rango de los horarios del SPA", Mensaje.ErrorIngreso);
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al cargar los horarios del SPA", Mensaje.ErrorBD);
                                }
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrió un error al mostrar los datos de la reserva", Mensaje.ErrorBD);
                            }
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error al mostrar los datos de la reserva", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarError("El Cliente ingresado no tiene una reserva confirmada con inicio para " + dtpFechaInico.Value.ToString("dd/MM/yyyy"), Mensaje.ErrorIngreso);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al buscar la Reserva", Mensaje.ErrorBD);
                    }
                }
                else if (retorno == 0)
                {
                    Mensaje.MostrarInfo("El Cliente ingresado no existe", "Aviso en alta de Servicio");
                }
                else
                {
                    Mensaje.MostrarError("Ocurrió un error al buscar el Cliente", Mensaje.ErrorBD);
                }
            }
        }

    }
}
