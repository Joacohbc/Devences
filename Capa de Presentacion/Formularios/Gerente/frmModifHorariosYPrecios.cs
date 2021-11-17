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
    public partial class frmModifHorariosYPrecios : Form
    {
        public frmModifHorariosYPrecios()
        {
            InitializeComponent();
        }

        private Validaciones validar = new Validaciones();

        #region Eventos del Form
        //Cerarr form
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

        private void frmModifHorariosYPrecios_Load(object sender, EventArgs e)
        {
            nudNormalMod.Maximum = Int32.MaxValue;
            nudIngAlojadosMod.Maximum = Int32.MaxValue;
            nudIngJubMod.Maximum = Int32.MaxValue;

            //Pongo el icono
            errorProvider.Icon = Properties.Resources.IconoError;

            cargarPrecios();
            cargarHorarios();
        }
        #endregion

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

                nudNormalMod.Value = Convert.ToInt32(txtIngNormal.Text);
                nudIngAlojadosMod.Value = Convert.ToInt32(txtIngAlojados.Text);
                nudIngJubMod.Value = Convert.ToInt32(txtIngJub.Text);
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

                dtpEntradaSpaMod.Value = DateTime.Parse(horarios[0]);
                dtpEntradaVestMod.Value = DateTime.Parse(horarios[1]);
                dtpSalidaSpaMod.Value = DateTime.Parse(horarios[2]);
                dtpSalidaVestMod.Value = DateTime.Parse(horarios[3]);
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

        private bool valdiarNoIgual()
        {
            if (txtIngNormal.Text == nudNormalMod.Value.ToString())
            {
                if (txtIngAlojados.Text == nudIngAlojadosMod.Value.ToString())
                {
                    if (txtIngJub.Text == nudIngJubMod.Value.ToString())
                    {
                        if (txtEntrada.Text == dtpEntradaSpaMod.Text)
                        {
                            if (txtSalida.Text == dtpSalidaSpaMod.Text)
                            {
                                if (txtEntradaVest.Text == dtpEntradaVestMod.Text)
                                {
                                    if (txtSalidaVest.Text == dtpSalidaVestMod.Text)
                                    {
                                        Mensaje.MostrarError("Los datos son iguales, cambie algun dato antes de realizar la modificacion", Mensaje.ErrorIngreso);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (valdiarNoIgual())
            {
                if (validar.validarHoraPrimeraEsMayor(dtpEntradaSpaMod.Value, dtpSalidaSpaMod.Value))
                {
                    if (validar.validarHoraPrimeraEsMayor(dtpEntradaVestMod.Value, dtpSalidaVestMod.Value))
                    {
                        if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar precios?", "Modificar precios"))
                        {
                            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                            try
                            {
                                int retorno = metodos.modificarPreciosIngreso(
                                Convert.ToInt32(nudNormalMod.Value), Convert.ToInt32(txtIngNormal.Text),
                                Convert.ToInt32(nudIngAlojadosMod.Value), Convert.ToInt32(txtIngAlojados.Text),
                                Convert.ToInt32(nudIngJubMod.Value), Convert.ToInt32(txtIngJub.Text));

                                if (retorno > 0)
                                {
                                    Mensaje.MostrarInfo("Modificacion de precios de ingreso exitosa", "Modificacion de precios");
                                    cargarPrecios();
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrio un error al modificar los precios", Mensaje.ErrorBD);
                                }
                            }
                            catch
                            {
                                Mensaje.MostrarError("Los precios deben ser valores enteros", Mensaje.ErrorIngreso);
                            }
                        }

                        if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar horarios?", "Modificar horarios"))
                        {
                            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                            int retorno = metodos.modificarHorarios(
                                dtpEntradaSpaMod.Value.ToShortTimeString(), txtEntrada.Text,
                                dtpEntradaVestMod.Value.ToShortTimeString(), txtEntradaVest.Text,
                                dtpSalidaSpaMod.Value.ToShortTimeString(), txtSalida.Text,
                                dtpSalidaVestMod.Value.ToShortTimeString(), txtSalidaVest.Text);

                            if (retorno > 0)
                            {
                                Mensaje.MostrarInfo("Modificacion de horarios de ingreso exitosa", "Modificacion de horarios");
                                cargarHorarios();
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrio un error al modificar los horarios", Mensaje.ErrorBD);
                            }
                        }

                    }
                    else
                    {
                        Mensaje.MostrarError("La fecha de entrada a los vestuarios debe ser anterior a la de salida", Mensaje.ErrorIngreso);
                    }
                }
                else
                {
                    Mensaje.MostrarError("La fecha de entrada al SPA debe ser anterior a la de salida", Mensaje.ErrorIngreso);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quieres vaciar los campo de modificacion?", "Borrar los campos"))
            {
                cargarPrecios();
            }
        }
    }
}
