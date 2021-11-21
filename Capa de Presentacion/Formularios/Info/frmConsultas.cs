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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
            Persona p = metodos.traerPersona(12345671);
            dataGridView1.Rows.Add("52626663" , p.PrimerNombre, p.PrimerApellido, p.SegundoApellido, p.Genero, p.FechaNacimiento, p.Mail);
        }

        private void frmInfoReservas_Load(object sender, EventArgs e)
        {
            cmbClave.Items.Add("CI");
            cmbClave.SelectedIndex = 0;

            cmbTipoConsulta.Items.Add("Empleados");
            cmbTipoConsulta.SelectedIndex = 0;

            txtBusqueda.Text = "52626663";
        }
    }
}
