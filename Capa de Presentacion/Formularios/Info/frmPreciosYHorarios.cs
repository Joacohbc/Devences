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
    public partial class frmPreciosYHorarios : Form
    {
        public frmPreciosYHorarios()
        {
            InitializeComponent();
            btnRefresh.PerformClick();
        }
        private void cargarPrecios()
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            List<String[]> precios = metodos.traerTiposDeIngresoPorSeparado();

            if (precios != null && precios.Count > 0)
            {
                foreach (String[] precio in precios)
                {
                    if (precio[0] == "Ingreso Normal")
                    {
                        txtIngNormal.Text = precio[1];
                    }
                    else if (precio[0] == "Ingreso de alojados")
                    {
                        txtIngAlojados.Text = precio[1];
                    }
                    else if (precio[0] == "Ingreso Jubilados/Pensionistas")
                    {
                        txtIngJub.Text = precio[1];
                    }
                }
            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error al cargar los precios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

                //Dehabilito todo menos el boton de salir
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                pnTitulo.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void cargarHorarios()
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            List<String> horarios = metodos.traerHorarios();

            if (horarios != null && horarios.Count > 0)
            {
                txtEntrada.Text = horarios[0];
                txtEntradaVest.Text = horarios[1];
                txtSalida.Text = horarios[2];
                txtSalidaVest.Text = horarios[3];
            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error al cargar los horarios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

                //Dehabilito todo menos el boton de salir
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                pnTitulo.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargarPrecios();
            cargarHorarios();
        }

        private void frmPreciosYHorarios_Load(object sender, EventArgs e)
        {
            cargarPrecios();
            cargarHorarios();
        }
    }
}
