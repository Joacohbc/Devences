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
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacios ¿Quieres cerrar igual?", "Cerrar")) Close();
            }
            else
            {
                Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            Func<String, bool> siConsulta = tipoConsulta => cmbTipoConsulta.SelectedItem.ToString() == tipoConsulta;
            Action error = () => Mensaje.MostrarError("Ocurrio un error al cargar los datos", Mensaje.ErrorBD);

            if (siConsulta(TodosLosClientesActivos)) {
                if (!metodos.csVerTodosLosClientesActivos(dgvConsulta)) error();
            }
            else if (siConsulta(TodosLosClientesInactivos)) {
                if (!metodos.csVerTodosLosClientesInactivos(dgvConsulta)) error();
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
        }

        //Consultas de Clientes
        private const String TodosLosClientesActivos = "Consultar todos los Clientes datos activos";
        private const String TodosLosClientesInactivos = "Consultar todos los Clientes inactivos";

        //Consultas de Empleado
        private const String TodosLosEmpleados = "Consultar todos los Empleados";

        //Consultas de Reserva
        private const String TodasLasReservas = "Consultar todas los Reservas";
        private const String TodasLasReservasConfirmadas = "Consultar todas los Reservas confirmadas";
        private const String TodasLasReservasCanceladas = "Consultar todas los Reservas canceladas";
        private const String TodasLasReservasFinalizadas = "Consultar todas los Reservas finalizadas";

        private void frmInfoReservas_Load(object sender, EventArgs e)
        {
            Action<String> cargar = consulta => cmbTipoConsulta.Items.Add(consulta);


            //Cliente
            cargar(TodosLosClientesActivos);
            cargar(TodosLosClientesInactivos);

            //Reserva
            cargar(TodasLasReservas);
            cargar(TodasLasReservasConfirmadas);
            cargar(TodasLasReservasCanceladas);
            cargar(TodasLasReservasFinalizadas);

            //Empleados
            cargar(TodosLosEmpleados);

            cmbTipoConsulta.SelectedIndex = 0;
        }

        private void cmbTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
