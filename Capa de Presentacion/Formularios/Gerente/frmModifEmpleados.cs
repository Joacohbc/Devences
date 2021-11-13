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
    public partial class frmModifEmpleados : Form
    {
        public frmModifEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContra.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
                chkMostrarContra.Image = Properties.Resources.ojo_cerrado;

            }
            else if (!chkMostrarContra.Checked)
            {
                txtContra.UseSystemPasswordChar = true;
                chkMostrarContra.Image = Properties.Resources.ojo;
            }
        }

        private void btnBuscarCed_Click(object sender, EventArgs e)
        {








            chkMostrarContra.Checked = false;
            chkMostrarContra.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {









            chkMostrarContra.Checked = true;
            chkMostrarContra.Visible = false;
        }
    }
}
