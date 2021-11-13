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
    public partial class frmPreciosYHorarios : Form
    {
        public frmPreciosYHorarios()
        {
            InitializeComponent();
            btnRefresh.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Aca va se cargan los textbox, se ejecuta en el load del form y se puede refrescar cuando ya esta abierto.
        }
    }
}
