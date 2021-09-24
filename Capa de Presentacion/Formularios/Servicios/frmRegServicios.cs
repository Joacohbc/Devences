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
    public partial class frmRegServicios : Form
    {
        private Validaciones validar = new Validaciones();
        private List<Capa_Entidades.Servicios> servicios;
        public frmRegServicios()
        {
            InitializeComponent();
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        private void frmRegServicios_Load(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
            servicios = metodos.traerServicios();

            if (servicios != null)
            {
                foreach (Capa_Entidades.Servicios s in servicios)
                {
                    //Agrego los servicios al CMB y al DGV
                    String cantidad = s.Cantidad == 0 ? "---" : s.Cantidad.ToString();
                    dgvServicios.Rows.Add(s.Nombre, s.CapacidadMaxima, cantidad, s.Precio);
                    cmbServicio.Items.Add(s.Nombre);
                }

                cmbServicio.SelectedIndex = 0;
                cmbFormaDePago.SelectedIndex = 0;

                dtpInicioServicio.MinDate = DateTime.Now;
            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error al cargar los servicios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                panel1.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedulaTitular, dtpFechaInico, dtpInicioServicio, cmbServicio, cmbFormaDePago };
                validar.limpiarControles(controles);

                //Y borro el error provider
                errorProvider.Clear();
            }
        }

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
                    reserva.Ci = Convert.ToInt32(txtCedulaTitular.Text);
                    reserva.Inicio = dtpFechaInico.Value;

                    retorno = metodos.validarFechaReserva(reserva);
                    if (retorno == 1)
                    {
                        //Intendo dar de Alta el Servicio
                        retorno = metodos.altaServicio(Convert.ToInt32(txtCedulaTitular.Text), servicios[cmbServicio.SelectedIndex], dtpFechaInico.Value, dtpInicioServicio.Value, cmbFormaDePago.SelectedItem.ToString());
                        if(retorno > 0)
                        {
                            Mensaje.MostrarInfo("Alta de Servicio exitosa", "Alta exitosa");
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrio un error al dar de alta el Servicio", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarError("El Cliente ingresado no tiene una reserva con inicio en " + dtpFechaInico.Value.ToString("dd/MM/yyyy"), Mensaje.ErrorIngreso);
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
