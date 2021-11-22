using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Logica;
using Capa_Logica.Clases;

namespace Capa_Presentacion.Formularios
{
    public partial class frmInfoReservas : Form
    {
        public frmInfoReservas()
        {
            InitializeComponent();
        }

        private Validaciones validar = new Validaciones();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (validar.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacíos, ¿Quieres cerrar igual?", "Cerrar")) Close();
            }
            else
            {
                Close();
            }
        }

        private void desactivar()
        {
            cmbClave.Items.Clear();
            cmbClave.Enabled = false;

            txtBusqueda.Enabled = false;
            txtBusqueda.Clear();

            btnBusqueda.Enabled = false;

            dtpInicio.Enabled = false;
            dtpFin.Enabled = false;
        }

        private void activar()
        {
            cmbClave.Enabled = true;
            txtBusqueda.Enabled = true;
            btnBusqueda.Enabled = true;
            dtpInicio.Enabled = true;
            dtpFin.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            Func<String, bool> siConsulta = tipoConsulta => cmbTipoConsulta.SelectedItem.ToString() == tipoConsulta;
            Action error = () => Mensaje.MostrarError("Ocurrió un error al cargar los datos", Mensaje.ErrorBD);

            if (siConsulta(TodosLosClientesActivos))
            {
                if (!metodos.csVerTodosLosClientesActivos(dgvConsulta)) error();
            }
            else if (siConsulta(TodosLosClientesInactivos))
            {
                if (!metodos.csVerTodosLosClientesInactivos(dgvConsulta)) error();
            }
            else if (siConsulta(TodosLosEmpleados))
            {
                if (!metodos.csVerTodasLosEmpleado(dgvConsulta)) error();
            }
            else if (siConsulta(TodasLasReservas))
            {
                if (!metodos.csVerTodasLasReservas(dgvConsulta)) error();
            }
            else if (siConsulta(TodasLasReservasConfirmadas))
            {
                if (!metodos.csVerTodasLasReservasConfirmada(dgvConsulta)) error();
            }
            else if (siConsulta(TodasLasReservasCanceladas))
            {
                if (!metodos.csVerTodasLasReservasCancelada(dgvConsulta)) error();
            }
            else if (siConsulta(TodasLasReservasFinalizadas))
            {
                if (!metodos.csVerTodasLasReservasFinalizada(dgvConsulta)) error();
            }
            else if (siConsulta(ServicioDeReserva))
            {
                try
                {
                    if (!metodos.csVerTodosServiciosDeReserva(Convert.ToInt32(txtBusqueda.Text), dgvConsulta)) error();
                }
                catch
                {
                    Mensaje.MostrarError("Ingrese un ID valido", Mensaje.ErrorIngreso);
                }
            }
            else if (siConsulta(VerCliente))
            {
                if(cmbClave.SelectedIndex == 0)
                {
                    if (ValidarPersona.ValidarCedula(txtBusqueda, errorProvider))
                    {
                        if (!metodos.csVerCliente(txtBusqueda.Text, String.Empty, dgvConsulta)) error();
                    }
                    else
                    {
                        Mensaje.MostrarError("Ingrese una cedula valido", Mensaje.ErrorIngreso);
                    }
                }
                else
                {
                    if (!metodos.csVerCliente(String.Empty, txtBusqueda.Text, dgvConsulta)) error();
                }
            }
            else if (siConsulta(ReservaPorFecha))
            {
                if (!metodos.csVerReservaEntreFechas(dtpInicio.Value,dtpFin.Value,dgvConsulta)) error();
            }
            /*LAS DE BASE DE DATOS*/
            else if (siConsulta(ReservasUltimoMes))//La De BD 2
            {
                if (!metodos.csVerReservasEnElUltimoMes(dgvConsulta)) error();
            }
            else if (siConsulta(PorcentajeServicios))//La De BD 5
            {
                if (!metodos.csPorcentajeServicio(dgvConsulta)) error();
            }
            else if (siConsulta(TotalFacuturadoUltimoMes))//La De BD 7
            {
                if (!metodos.csFacturasUltMesServ(dgvConsulta)) error();
            }
            else if (siConsulta(CantidadVecesServicio))//La De BD 12
            {
                if (!metodos.csVerCantidadVecesServicio(dgvConsulta)) error();
            }
        }

        //Consultas de Clientes
        private const String TodosLosClientesActivos = "Todos los Clientes activos";
        private const String TodosLosClientesInactivos = "Todos los Clientes inactivos";
        private const String VerCliente = "Cliente por Cedula/Nombre";

        //Consultas de Empleado
        private const String TodosLosEmpleados = "Todos los Empleados";

        //Consultas de Reserva
        private const String TodasLasReservas = "Todas las Reservas";
        private const String TodasLasReservasConfirmadas = "Todas las Reservas confirmadas";
        private const String TodasLasReservasCanceladas = "Todas las Reservas canceladas";
        private const String TodasLasReservasFinalizadas = "Todas las Reservas finalizadas";

        //Servicios
        private const String ServicioDeReserva = "Todos los servicios de una reserva";
        private const String ReservaPorFecha = "Reserva por fecha";

        //Sentencias de BD
        private const String PorcentajeServicios = "Porcentaje de ocupacion de servicios";
        private const String ReservasUltimoMes = "Reservas en el ultimo mes";
        private const String TotalFacuturadoUltimoMes = "Total facturado por servicio en ultimo mes";
        private const String CantidadVecesServicio = "Cantidad de servicios en el ultimo mes";

        private void frmInfoReservas_Load(object sender, EventArgs e)
        {
            errorProvider.Icon = Properties.Resources.IconoError;

            Action<String> cargar = consulta => cmbTipoConsulta.Items.Add(consulta);

            //Cliente
            cargar(TodosLosClientesActivos);
            cargar(TodosLosClientesInactivos);

            //Reserva
            cargar(TodasLasReservas);
            cargar(TodasLasReservasConfirmadas);
            cargar(TodasLasReservasCanceladas);
            cargar(TodasLasReservasFinalizadas);
            cargar(VerCliente);
            cargar(ReservaPorFecha);

            //Empleados
            cargar(TodosLosEmpleados);

            //Servicios
            cargar(CantidadVecesServicio);
            cargar(ServicioDeReserva);

            //Sentencias
            cargar(ReservasUltimoMes);
            cargar(PorcentajeServicios);
            cargar(TotalFacuturadoUltimoMes);


            cmbTipoConsulta.SelectedIndex = 0;

            desactivar();
        }

        private void cmbTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<String, bool> siConsulta = tipoConsulta => cmbTipoConsulta.SelectedItem.ToString() == tipoConsulta;

            desactivar();

            if (siConsulta(ServicioDeReserva))
            {
                cmbClave.Items.Add("ID");
                cmbClave.SelectedIndex = 0;

                txtBusqueda.Enabled = true;

                btnBusqueda.Enabled = true;
            }
            else if (siConsulta(VerCliente))
            {
                cmbClave.Items.Add("Cedula");
                cmbClave.Items.Add("Nombre");
                cmbClave.SelectedIndex = 0;

                cmbClave.Enabled = true;

                txtBusqueda.Enabled = true;
                btnBusqueda.Enabled = true;
            }
            else if (siConsulta(ReservaPorFecha))
            {
                dtpInicio.Enabled = true;
                dtpFin.Enabled = true;
            }
            else
            {
                btnActualizar.PerformClick();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
