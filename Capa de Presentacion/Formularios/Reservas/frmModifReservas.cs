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
    public partial class frmModifReservas : Form
    {
        private Reserva reservaAModificar = new Reserva();
        private List<Integrantes> IntegrantesModificar = new List<Integrantes>();

        Validaciones validar = new Validaciones();

        #region Eventos del Form
        public frmModifReservas()
        {
            InitializeComponent();
        }

        private void frmModifReservas_Load(object sender, EventArgs e)
        {
            errorProvider.Icon = Properties.Resources.IconoError;

            dtpFechaInicio.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            dtpFechaFin.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            dtpModificarFechaInicio.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            dtpModificarFechaFin.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        }

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
        private void txtCedulaTitular_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaTitular, "");
        }

        private void txtCedulaTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }
        #endregion

        //Eliminar Reserva
        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere cancelar la reserva? Este proceso es irreversible", "Modificar reserva"))
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Si la baj se dio con exito
                if (metodos.bajaReserva(reservaAModificar.Id) > 0)
                {
                    Mensaje.MostrarInfo("Baja de reserva exitosa", "Baja de reserva");
                    limpiar();
                }
                else
                {
                    Mensaje.MostrarError("Ocurrió un error al dar de baja la reserva", Mensaje.ErrorBD);
                }
            }
        }

        //Buscar reserva
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Valido que la Cedula sea valida
            if (ValidarPersona.ValidarCedula(txtCedulaTitular, errorProvider))
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                int retorno = metodos.buscarCliente(Convert.ToInt32(txtCedulaTitular.Text));

                //Que el cliente exista
                if (retorno > 0)
                {
                    //Creo un objeto reserva
                    Reserva reserva = new Reserva();
                    reserva.Ci = Convert.ToInt32(txtCedulaTitular.Text);
                    reserva.Inicio = dtpModificarFechaInicio.Value;

                    //Lo uso para verificar su Id
                    retorno = metodos.buscarIdReserva(reserva);

                    //Si hay ID, osea la reserva existe
                    if (retorno > 0)
                    {
                        //Traigo todos los datos de la reserva
                        reserva = metodos.traerReserva(Convert.ToInt32(txtCedulaTitular.Text), dtpModificarFechaInicio.Value);

                        //Si no ocurrio ningun error
                        if (reserva != null || reserva.Ci == -1)
                        {
                            //Si la reserva NO comenzo
                            if (reserva.Inicio > DateTime.Today)
                            {
                                //Compruebo los servicios reservados
                                retorno = metodos.comprobarCantidadServiciosEnReserva(reservaAModificar.Id);

                                //Si no tiene ninguno
                                if (retorno == 0)
                                {
                                    List<Integrantes> integrantes = metodos.traerIntegrantes(reserva.Id);
                                    if (integrantes != null)
                                    {
                                        foreach (Integrantes integrante in integrantes)
                                        {
                                            Persona persona = metodos.traerPersona(integrante.Ci);
                                            if (persona != null)
                                            {
                                                dgvIntegrantes.Rows.Add(persona.PrimerNombre, persona.PrimerApellido, persona.Genero, integrante.TipoDeIngreso);
                                            }
                                            else
                                            {
                                                Mensaje.MostrarError("Ocurrió un error al buscar los datos del Cliente", Mensaje.ErrorBD);
                                            }
                                        }

                                        dtpFechaInicio.Value = reserva.Inicio;
                                        dtpFechaFin.Value = reserva.Fin;

                                        dtpModificarFechaInicio.Value = reserva.Inicio;
                                        dtpModificarFechaFin.Value = reserva.Fin;

                                        chkConfirmada.Checked = reserva.Estado == "Confirmada" ? true : false;
                                        chkConfirmada.Enabled = reserva.Estado == "No Confirmada" ? true : false;

                                        //Des habilito esto
                                        txtCedulaTitular.Enabled = false;
                                        dtpModificarFechaInicio.Enabled = false;
                                        btnBuscar.Enabled = false;

                                        //Habilito las opciones del edicion
                                        dtpFechaInicio.Enabled = true;
                                        dtpFechaFin.Enabled = true;
                                        btnEliminarReserva.Enabled = true;
                                        btnModificar.Enabled = true;
                                        btnCancelar.Enabled = true;

                                        Mensaje.MostrarInfo("La reserva se cargó correcamente, ya puede empezar a modificar", "Aviso");
                                        reservaAModificar = reserva;
                                        IntegrantesModificar = integrantes;
                                    }
                                    else
                                    {
                                        Mensaje.MostrarError("Ocurrió un error al cargar los Integrantes", Mensaje.ErrorBD);
                                    }
                                }
                                else if (retorno > 0)
                                {
                                    Mensaje.MostrarError("La reserva ya tiene servicios registrados, si quiere modificarla deberá cancelarlos", Mensaje.ErrorIngreso);
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al comprobar los servicios", Mensaje.ErrorBD);
                                }

                            }
                            else
                            {
                                Mensaje.MostrarError("La reserva ya comenzó, no se puede modificar", Mensaje.ErrorIngreso);
                            }
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error al verificar la reserva", Mensaje.ErrorBD);
                        }
                    }
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarError("El Titular no tiene una reserva con ese inicio", Mensaje.ErrorIngreso);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al verificar la reserva", Mensaje.ErrorBD);
                    }
                }
                else if (retorno == 0)
                {
                    Mensaje.MostrarError("El Titular no está registrado como cliente", Mensaje.ErrorIngreso);
                }
                else
                {
                    Mensaje.MostrarError("Ocurrió un error al buscar el Titular", Mensaje.ErrorBD);
                }
            }
        }

        //Modificar Reserva
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Si la 1ra fecha selecionada es mayor a la anterior
            if (validar.validarFechaPrimeraEsMenor(dtpFechaInicio.Value, dtpFechaFin.Value))
            {
                //Si esta "No Confirmada" y tiene inicio hoy, no te dejara reservarla
                //ya que si empieza hoy deberia estar pga
                if ((chkConfirmada.Checked && dtpFechaInicio.Value.Date >= DateTime.Today) || (!chkConfirmada.Checked && dtpFechaInicio.Value.Date > DateTime.Today))
                {
                    MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                    Object[] validarFecha = metodos.comprobarDiasTodosDiasReservasAModificar(reservaAModificar.Ci, reservaAModificar.Id, dtpFechaInicio.Value, dtpFechaFin.Value);

                    //Si todos los dia son validos
                    if ((int)validarFecha[1] == 0)
                    {
                        if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar la reserva del " + dtpFechaInicio.Value.ToShortDateString() + " al " + dtpFechaFin.Value.ToShortDateString() + "?", "Modificar Reserva"))
                        {
                            //Para recalcular el precio pone el precio actual en 0
                            reservaAModificar.PrecioTotal = 0;

                            //Determina el nuevo estado de la reserva
                            String estado = chkConfirmada.Checked ? "Confirmada" : "No Confirmada";

                            int retornar = metodos.modificarReserva(reservaAModificar, IntegrantesModificar, dtpFechaInicio.Value, dtpFechaFin.Value, estado);

                            //Si la reserva se modifica con exito
                            if (retornar > 0)
                            {
                                Mensaje.MostrarInfo("La Reserva se modificó con éxito", "Modificación de Reserva");
                                btnCancelar.PerformClick();
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrió un error al modificar la reserva", Mensaje.ErrorBD);
                            }
                        }
                    }
                    //Si ese dia ya estaba reservado
                    else if ((int)validarFecha[1] == 1)
                    {
                        Mensaje.MostrarError("El Cliente ya tiene reservado el dia " + ((DateTime)validarFecha[0]).ToShortDateString() + " en alguna de sus reservas", Mensaje.ErrorIngreso);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al validar los días de la reserva", Mensaje.ErrorBD);
                    }
                }
                else
                {
                    Mensaje.MostrarError("La reserva deberá ser confirmada si quiere iniciarla hoy", Mensaje.ErrorIngreso);
                }
            }
            else
            {
                Mensaje.MostrarError("La fecha de inicio debe ser anterior a la de fin", Mensaje.ErrorIngreso);
            }
        }

        //Descarcartar Reserva
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere vaciar todos los campos?", "Vaciar campos"))
            {
                limpiar();
            }
        }

        //Limpia to'
        private void limpiar()
        {
            //Limpio los componenetes
            Control[] controles = { txtCedulaTitular, dtpFechaInicio, dtpFechaFin, dtpModificarFechaInicio,
                    dtpModificarFechaFin, chkConfirmada, dgvIntegrantes};

            validar.limpiarControles(controles);

            //Des habilito esto
            txtCedulaTitular.Enabled = true;
            dtpModificarFechaInicio.Enabled = true;
            btnBuscar.Enabled = true;

            //Habilito las opciones del edicion
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            btnEliminarReserva.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            chkConfirmada.Enabled = false;

            //Y borro el error provider
            errorProvider.Clear();
        }
        
        //Confirmar la reserva
        private void chkConfirmada_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Seguro que quiere confirmar la reserva? Este proceso es irreversible" +
                 "una vez se modifique la reserva", "Modificar Reserva"))
            {
                chkConfirmada.Checked = true;
                chkConfirmada.Enabled = false;
            }
            else
            {
                chkConfirmada.Checked = false;
            }
        }
    }
}
