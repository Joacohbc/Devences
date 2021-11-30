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

namespace Capa_Presentacion.Formularios
{
    public partial class frmRegReservas : Form
    {
        private List<Integrantes> integrantes = new List<Integrantes>();

        private Validaciones validar = new Validaciones();

        public frmRegReservas()
        {
            InitializeComponent();
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        #region Eventos del Form
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

        //Cargo los datos en los CMB y asigno Min y Max a los DTP
        private void frmRegReservas_Load(object sender, EventArgs e)
        {
            dtpFechaInico.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            dtpFechaFin.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            //Cargo los Combobox
            MetodosEmpleado metodosEmpleado = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            List<String> tiposDeIngreso = metodosEmpleado.traerTipoIngreso();

            //Si no es NULL, osea se cargo correctamente los tipos de ingreso
            if (tiposDeIngreso != null)
            {
                foreach (String ingreso in tiposDeIngreso)
                {
                    cmbTipoDeIngreso.Items.Add(ingreso);
                    cmbTipoIngresoIntegrante.Items.Add(ingreso);
                }

                //Se selecciona el primero por defecto
                cmbTipoDeIngreso.SelectedIndex = 0;
                cmbTipoIngresoIntegrante.SelectedIndex = 0;
                cmbMetodosPago.SelectedIndex = 0;

                //Logo del ErrorProvider
                errorProvider.Icon = Properties.Resources.IconoError;
            }
            else
            {
                Mensaje.MostrarError("Ocurrió un error la cargar los tipos de ingreso, cierre esta pestaña e inténtelo nuevamente", Mensaje.ErrorBD);

                //Si ocurre un error se desahbiilita todo menos el boton de Cierre del Form
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                panel1.Enabled = true;
                btnSalir.Enabled = true;
            }
        }
        #endregion

        #region Validciones de Ingreso
        //Cedula Titular
        private void txtCedulaTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedulaTitular_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaTitular, "");
        }

        //Cedula Integrante
        private void txtCedulaIntegrante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedulaIntegrante_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaIntegrante, "");
        }
        #endregion

        #region Validacions de Ingreso de Integrantes
        //Agregar Integrante
        private void btnAgregarIntegrante_Click(object sender, EventArgs e)
        {
            //Valido la cedula del Integrante
            if (ValidarPersona.ValidarCedula(txtCedulaIntegrante, errorProvider))
            {
                //Valido que no este ya en la lista
                if (!listIntegrantes.Items.Contains(txtCedulaIntegrante.Text))
                {
                    MetodosEmpleado metodosEmpleado = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                    int retorno = metodosEmpleado.buscarCliente(Convert.ToInt32(txtCedulaIntegrante.Text));

                    //Valido que el Integrante exista
                    if (retorno == 1)
                    {
                        //Esto lo hago primero para que en caso de error
                        //No agregue el Integrante al las listas

                        //Agrego el integrante al DGV de Integrantes
                        Persona persona = metodosEmpleado.traerPersona(Convert.ToInt32(txtCedulaIntegrante.Text));
                        if (persona != null)
                        {
                            //Agrego el integrante a la lista de Integrantes
                            String tipoDeIngreso = cmbTipoIngresoIntegrante.SelectedItem.ToString();

                            //Agrego el tipo de Ingreso pero sin el ($Precio) para que se igual que en la BD
                            tipoDeIngreso = tipoDeIngreso.Substring(0, tipoDeIngreso.IndexOf('('));

                            integrantes.Add(new Integrantes(Convert.ToInt32(txtCedulaIntegrante.Text), tipoDeIngreso));

                            //Agrego el integrante a la listBox de Integrantes                       
                            listIntegrantes.Items.Add(txtCedulaIntegrante.Text);

                            dgvIntegrantes.Rows.Add(persona.PrimerNombre, persona.PrimerApellido, persona.Genero, cmbTipoIngresoIntegrante.SelectedItem.ToString());
                            Mensaje.MostrarInfo("Se cargó el integrante con éxito", "Carga de Integrante exitosa");
                            txtCedulaIntegrante.Clear();
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error buscar los datos del Cliente", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarInfo("El Cliente que intenta agregar como Integrante no existe", "Aviso en busqueda de Cliente");
                    }
                    //Si dio Error
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error buscar el Cliente", Mensaje.ErrorBD);
                    }
                }
                else
                {
                    Mensaje.MostrarError("El Integrante que quiere agregar ya se encuentra agregado", Mensaje.ErrorIngreso);
                }
            }
        }

        //Borrar Integrante
        private void btnBorrarIntegrante_Click(object sender, EventArgs e)
        {
            //Si Integrantes en la lista
            if (listIntegrantes.Items.Count > 0)
            {
                //Si hay uno seleccionado
                if (listIntegrantes.SelectedItem != null)
                {
                    //Pregunta si quiere eliminarlo
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere eliminar el integrante seleccionado?", "Borrar Integrante"))
                    {
                        try
                        {
                            integrantes.RemoveAt(listIntegrantes.SelectedIndex);
                            dgvIntegrantes.Rows.RemoveAt(listIntegrantes.SelectedIndex);

                            //Lo pongo al final porque si borro el Index seleccionado primero, luego
                            //El index seleccionado pasa a ser -1, y cuando quira borrar el index
                            //En los otros me tirara error ya que el index -1 no existe
                            listIntegrantes.Items.RemoveAt(listIntegrantes.SelectedIndex);
                        }
                        catch
                        {
                            Mensaje.MostrarError("Ocurrió un error al borrar a un integrante", "Error al borrar Integrante");

                            //Para evitar errores mas adelante vacio las listas y el DGV
                            listIntegrantes.Items.Clear();
                            integrantes.Clear();
                            dgvIntegrantes.Rows.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un integrante", "Error al borrar Integrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero ingrese un integrante", "Error al borrar Integrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Agregar Reserva
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            //Cargo el Array Object con el Metodo, en el Index 0 esta el Objeto Reserva y en el Index 1 esta el numero de Error
            Object[] reserva = metodos.validarReserva(txtCedulaTitular, errorProvider, dtpFechaInico, dtpFechaFin, cmbTipoDeIngreso, cmbMetodosPago, chkConfirmada, integrantes);

            Reserva reservaFinal = (Reserva)reserva[0];
            //Compruebo si la Reserva es Valida

            //En el Index 1 deberia haber un 1 si la valdacion fue correcta
            if (Convert.ToInt32(reserva[1]) == 1)
            {
                //Si ese cliente no tiene una reserva con ese inicio
                int retorno = metodos.buscarIdReserva((Reserva)reserva[0]);

                if (retorno == 0)
                {
                    Object[] validarFecha = metodos.comprobarDiasTodosDiasReservas(reservaFinal.Ci, reservaFinal.Inicio, reservaFinal.Fin);

                    if ((int)validarFecha[1] == 0)
                    {
                        if (Mensaje.MostraPreguntaSiNo("¿Quiere dar de alta una Reserva para el cliente " + txtCedulaTitular.Text + " " +
                                "\n del " + dtpFechaInico.Value.ToShortDateString() + " al " + dtpFechaFin.Value.ToShortDateString() + "?", "Alta Reserva"))
                        {
                            //Si la Reserva se dio de Alta con Exito, osea retorna 1
                            if (metodos.altaReserva((Reserva)reserva[0], integrantes) > 0)
                            {
                                Mensaje.MostrarInfo("Alta de Reserva exitosa", "Alta exitosa");
                            }
                            //Sino ocurrio un error
                            else
                            {
                                Mensaje.MostrarError("Ocurrió un error al dar de alta la Reserva", Mensaje.ErrorBD);
                            }
                        }
                    }
                    else if ((int)validarFecha[1] == 1)
                    {
                        Mensaje.MostrarError("El Cliente ya tiene reservado el dia " + ((DateTime)validarFecha[0]).ToShortDateString() + " en alguna de sus reservas", Mensaje.ErrorIngreso);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al validar los días de la reserva", Mensaje.ErrorBD);
                    }
                }
                else if (retorno > 0)
                {
                    Mensaje.MostrarError("El Cliente ya tiene una reserva registrada con ese inicio", Mensaje.ErrorIngreso);
                }
                else if (retorno == -1)
                {
                    Mensaje.MostrarError("Ocurrió un error al validar la fecha de la Reserva", Mensaje.ErrorBD);
                }
            }
            //Si el Titular es un Integrante muestro el Error
            //En el Index 1 deberia haber un -1 si la el titular es un integrante
            else if (Convert.ToInt32(reserva[1]) == -1)
            {
                Mensaje.MostrarError("El cliente Titular no puede ser un Integrante de la Reserva", Mensaje.ErrorIngreso);
            }
            //Si el Titular no existe como cliente
            //En el Index 1 deberia haber un -2 si el Titular no existe
            else if (Convert.ToInt32(reserva[1]) == -2)
            {
                Mensaje.MostrarError("El Titular no está registrado como cliente", Mensaje.ErrorIngreso);
            }
            //Si al buscar al TItular ocurrio un error
            //En el Index 1 deberia haber un -3 si hay error en buscar al Titular
            else if (Convert.ToInt32(reserva[1]) == -3)
            {
                Mensaje.MostrarError("Ocurrió un error al buscar el Titular", Mensaje.ErrorBD);
            }
            //Si la Fecha de inicio es hoy y la reserva No Esta Confirmada
            //En el Index 1 deberia haber un -4 
            else if (Convert.ToInt32(reserva[1]) == -4)
            {
                Mensaje.MostrarError("La reserva deberá ser confirmada si quiere iniciarla hoy", Mensaje.ErrorIngreso);
            }
            //Si la Fecha de inicio es posterior a la de Fin muestro error
            //En el Index 1 deberia haber un -2 si hay un error en las fecha
            else if (Convert.ToInt32(reserva[1]) == -5)
            {
                Mensaje.MostrarError("La fecha de inicio debe ser anterior a la de fin", Mensaje.ErrorIngreso);
            }
        }

        //Descartar reserva
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere vaciar los campos?", "Vaciar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedulaTitular, txtCedulaIntegrante, dtpFechaInico, dtpFechaFin, chkConfirmada, listIntegrantes, dgvIntegrantes };

                validar.limpiarControles(controles);

                //Le pongo la MinDate nuevamente en Hoy
                dtpFechaInico.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                dtpFechaFin.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());


                //Para que vuela a tener el predeterminado en el primero
                cmbTipoDeIngreso.SelectedIndex = 0;
                cmbTipoIngresoIntegrante.SelectedIndex = 0;
                cmbMetodosPago.SelectedIndex = 0;

                //Borro los integrantes
                integrantes.Clear();

                //Y borro el error provider
                errorProvider.Clear();
            }
        }

    }
}
