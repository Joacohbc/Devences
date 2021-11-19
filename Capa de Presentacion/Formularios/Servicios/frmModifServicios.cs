using Capa_Entidades;
using Capa_Logica;
using Capa_Logica.Clases;
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
    public partial class frmModifServicios : Form
    {
        private Reserva reserva = new Reserva();

        private Validaciones validar = new Validaciones();

        public frmModifServicios()
        {
            InitializeComponent();
        }

        #region Eventos del Form
        private void frmModifServicios_Load(object sender, EventArgs e)
        {
            dtpFechaInico.MinDate = DateTime.Today;
            dtpFechaInico.Value = DateTime.Today;

            dtpInicioServicio.MinDate = DateTime.Today;
            dtpInicioServicio.Value = DateTime.Now;

            errorProvider.Icon = Properties.Resources.IconoError;
        }

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

        private void recargarDGV()
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
            List<String[]> servicios = metodos.traerServiciosDeUnaReserva(reserva.Id);
            if (servicios != null)
            {
                if (servicios.Count > 0)
                {
                    cmbServicio.Items.Clear();
                    dgvServicios.Rows.Clear();

                    foreach (String[] servicio in servicios)
                    {
                        dgvServicios.Rows.Add(servicio[0], servicio[1], servicio[2]);
                        cmbServicio.Items.Add(servicio[0]);
                    }
                    cmbServicio.SelectedIndex = 0;
                }
                else
                {
                    Mensaje.MostrarInfo("Esta reserva no tiene ningun servicio registrado", "Aviso");
                    limpiar();
                }
            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error al traer los servicios de la reserva", Mensaje.ErrorBD);
            }
        }

        private bool servicioYaInicio()
        {
            DateTime inicio = DateTime.Parse(dgvServicios.Rows[cmbServicio.SelectedIndex].Cells[1].Value.ToString());
            if (inicio < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Valido que la cedula sea correcta
            if (ValidarPersona.ValidarCedula(txtCedulaTitular, errorProvider))
            {
                //Creo objeto para usar los metodos de BBDD
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

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
                        reserva = metodos.traerReserva(Convert.ToInt32(txtCedulaTitular.Text), dtpFechaInico.Value);

                        if (reserva != null)
                        {
                            List<String[]> servicios = metodos.traerServiciosDeUnaReserva(reserva.Id);
                            if (servicios != null)
                            {
                                if (servicios.Count > 0)
                                {
                                    foreach (String[] servicio in servicios)
                                    {
                                        dgvServicios.Rows.Add(servicio[0], servicio[1], servicio[2]);
                                        cmbServicio.Items.Add(servicio[0]);
                                    }

                                    //Deshabilito los componentes de busqueda
                                    txtCedulaTitular.Enabled = true;
                                    btnBuscar.Enabled = true;
                                    dtpFechaInico.Enabled = true;

                                    //Habilito los componentes de modificacion
                                    cmbServicio.Enabled = true;
                                    cmbServicio.SelectedIndex = 0;
                                    dtpInicioServicio.Enabled = true;
                                    btnEliminarServicio.Enabled = true;
                                    btnModificar.Enabled = true;
                                    btnCancelar.Enabled = true;
                                }
                                else
                                {
                                    Mensaje.MostrarError("Esta reserva no tiene ningun servicio registrado", Mensaje.ErrorIngreso);
                                }
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrio un error al traer los servicios de la reserva", Mensaje.ErrorBD);
                            }
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrio un error al traer los datos de la reserva", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarError("El Cliente ingresado no tiene una reserva del servico confirmada con inicio para " + dtpFechaInico.Value.ToString("dd/MM/yyyy"), Mensaje.ErrorIngreso);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!servicioYaInicio())
            {
                //Instancio el objeto para usar los metodos de la BD
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Traigo los servicios
                List<Capa_Entidades.Servicios> servicios = metodos.traerServicios();

                //Si son != de null sigmifica que cargaron bien
                if (servicios != null)
                {
                    //Creo un Servicio para cargar el servicio que se quiere modificar
                    Capa_Entidades.Servicios servicioSeleccionado = null;

                    //Le cargo el que se intento
                    servicios.ForEach(delegate (Capa_Entidades.Servicios servicio)
                    {
                        //En Servicio seleccionado guardo toda la info
                        if (cmbServicio.SelectedItem.ToString() == servicio.Nombre)
                        {
                            servicioSeleccionado = servicio;
                        }
                    });

                    if (servicioSeleccionado != null)
                    {
                        //Valido que el servicio este dentro de los horarios del SPA
                        int retorno = metodos.estaDentroDeHorarios(dtpInicioServicio.Value, (dtpInicioServicio.Value + servicioSeleccionado.Duracion));
                        if (retorno == 1)
                        {
                            //Creo este objeto para validar
                            Validaciones fechas = new Validaciones();

                            //Valido que la fecha de inicio del servico no ocurra antes que el inicio de la reserva al cual se le asgina
                            retorno = metodos.validarFechaServicio(reserva, dtpInicioServicio.Value);
                            if (retorno == 1)
                            {
                                //Compruebo que los cupos del servicio no esten llenos
                                retorno = metodos.validarMaxCantidadServicio(servicioSeleccionado, dtpInicioServicio.Value);
                                if (retorno == 1)
                                {
                                    if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar el servicio?", "Modificacion de Servicio"))
                                    {
                                        //Intendo Modificar el Servicio
                                        retorno = metodos.modificarServicioReservado(cmbServicio.SelectedItem.ToString(), reserva.Id, dtpInicioServicio.Value, servicioSeleccionado.Duracion);
                                        if (retorno > 0)
                                        {
                                            Mensaje.MostrarInfo("Modificacion de Servicio exitosa", "Modificacion exitosa");
                                            recargarDGV();
                                        }
                                        else
                                        {
                                            Mensaje.MostrarError("Ocurrio un error al modificar el Servicio", Mensaje.ErrorBD);
                                        }
                                    }
                                }
                                else if (retorno == 0)
                                {
                                    DateTime fin = dtpInicioServicio.Value + servicioSeleccionado.Duracion;
                                    Mensaje.MostrarError("Este servicio en el horario " + dtpInicioServicio.Value.ToLongTimeString() + " a " + fin.ToLongTimeString() +
                                        " ya esta lleno, eliga otro horario", Mensaje.ErrorIngreso);
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrio un error al comprobar la cantidad maxima del servicio", Mensaje.ErrorBD);
                                }
                            }
                            else if (retorno == -2)
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
                            Mensaje.MostrarError("La fecha de registro del servicio no se encuentra dentro del rango de los horarios del SPA", Mensaje.ErrorIngreso);
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrio un error al cargar los horarios del SPA", Mensaje.ErrorBD);
                        }
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrio un error al buscar el servicio", Mensaje.ErrorIngreso);
                    }
                }
                else
                {
                    Mensaje.MostrarError("Ocurrio un error al cargar los servicios", Mensaje.ErrorBD);
                }
            }
            else
            {
                Mensaje.MostrarError("El servicio seleccionado ya comenzo, no se puede realizar la operacion", Mensaje.ErrorIngreso);
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere cancelar el servicio seleccionado? Este proceso es irreversible", "Modificar servicio"))
            {
                if (!servicioYaInicio())
                {
                    MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                    //Si la baj se dio con exito
                    if (metodos.cancelarServicio(cmbServicio.SelectedItem.ToString(), reserva.Id) > 0)
                    {
                        Mensaje.MostrarInfo("El servicio se cancelo con exito", "Baja de servicio");
                        recargarDGV();
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrio un error al dar de baja la reserva", Mensaje.ErrorBD);
                    }
                }
                else
                {
                    Mensaje.MostrarError("El servicio seleccionado ya comenzo, no se puede realizar la operacion", Mensaje.ErrorIngreso);
                }
            }
        }

        private void limpiar()
        {
            //Limpio los componenetes
            Control[] controles = { txtCedulaTitular, dtpFechaInico, cmbServicio, dtpInicioServicio, dgvServicios };

            validar.limpiarControles(controles);

            //Le pongo la MinDate nuevamente en Hoy
            dtpFechaInico.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            dtpInicioServicio.MinDate = DateTime.Now;
            dtpInicioServicio.Value = DateTime.Now;

            //Habilito los componentes de busqueda
            txtCedulaTitular.Enabled = false;
            btnBuscar.Enabled = false;
            dtpFechaInico.Enabled = false;

            //Deshabilito los componentes de modificacion
            cmbServicio.Enabled = false;
            cmbServicio.SelectedIndex = 0;
            dtpInicioServicio.Enabled = false;
            btnEliminarServicio.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;


            cmbServicio.Items.Clear();
            dgvServicios.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                limpiar();
            }
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvServicios.Rows.Count > 0)
            {
                dtpInicioServicio.Value = DateTime.Parse(dgvServicios.Rows[cmbServicio.SelectedIndex].Cells[1].Value.ToString());
            }
        }
    }
}
