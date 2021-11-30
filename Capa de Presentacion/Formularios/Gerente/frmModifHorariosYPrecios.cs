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
        private List<Capa_Entidades.Servicios> servicios = new List<Capa_Entidades.Servicios>();

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
            nudPrecServMod.Maximum = Int32.MaxValue;

            //Pongo el icono
            errorProvider.Icon = Properties.Resources.IconoError;

            cargarPrecios();
            cargarHorarios();
            cargarServicios();
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
                Mensaje.MostrarError("Ocurrió un error al cargar los precios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

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
                Mensaje.MostrarError("Ocurrió un error al cargar los horarios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

                //Dehabilito todo menos el boton de salir
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                pnTitulo.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void cargarServicios()
        {
            //Instancio la Clase
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            //Guardo los servicios que traje en un List<>
            servicios = metodos.traerServicios();

            //Si no es null(Osea que los trajo exitosamente)
            if (servicios != null)
            {
                cmbServicio.Items.Clear();

                //Los Cargo en el CMB
                foreach (Capa_Entidades.Servicios s in servicios)
                {
                    cmbServicio.Items.Add(s.Nombre);
                }

                //Para que los CMB empienzen en algun elemento
                cmbServicio.SelectedIndex = 0;
            }
            else
            {
                Mensaje.MostrarError("Ocurrió un error al cargar los servicios, cierre este apartado e intente nuevamente", Mensaje.ErrorBD);

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
            if (igualPrecios())
            {
                if (igualHorarios())
                {
                    if (igualServicios())
                    {
                        Mensaje.MostrarError("Los datos son iguales, cambie algún dato antes de realizar la modificación", Mensaje.ErrorIngreso);
                        return false;
                    }
                }
            }
            return true;
        }

        //Si los datos de los Precios de Ingresos son iguales
        private bool igualPrecios()
        {
            if (txtIngNormal.Text == nudNormalMod.Value.ToString())
            {
                if (txtIngAlojados.Text == nudIngAlojadosMod.Value.ToString())
                {
                    if (txtIngJub.Text == nudIngJubMod.Value.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Si los datos de los Precios de Ingresos son iguales
        private bool igualHorarios()
        {
            if (txtEntrada.Text == dtpEntradaSpaMod.Text)
            {
                if (txtSalida.Text == dtpSalidaSpaMod.Text)
                {
                    if (txtEntradaVest.Text == dtpEntradaVestMod.Text)
                    {
                        if (txtSalidaVest.Text == dtpSalidaVestMod.Text)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //Si los datos de los Precios de Ingresos 
        private bool igualServicios()
        {
            if (txtPrecServ.Text == nudPrecServMod.Value.ToString())
            {
                if (txtDurServ.Text == dtpDurServMod.Text)
                {
                    return true;
                }
            }
            return false;
        }

        //Modificar Reserva
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Verifica que los datos no sean iguales
            if (valdiarNoIgual())
            {
                //Valida las fechas nueva de entrada al SPA
                if (validar.validarHoraPrimeraEsMayor(dtpEntradaSpaMod.Value, dtpSalidaSpaMod.Value))
                {
                    //Validas la fechas nuebas de entrada a los Vestuarios
                    if (validar.validarHoraPrimeraEsMayor(dtpEntradaVestMod.Value, dtpSalidaVestMod.Value))
                    {
                        //Si los datos son iguales que se salte este cartel
                        //Niego su igualdad, osea, si son iguales sigue de largo
                        //pero si son diferentes entra
                        if (!igualPrecios())
                        {
                            if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar los precios?", "Modificar precios"))
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
                                        Mensaje.MostrarInfo("Modificación de precios de ingreso exitosa", "Modificación de precios");
                                        cargarPrecios();
                                    }
                                    else
                                    {
                                        Mensaje.MostrarError("Ocurrió un error al modificar los precios", Mensaje.ErrorBD);
                                    }
                                }
                                catch
                                {
                                    Mensaje.MostrarError("Los precios deben ser valores enteros", Mensaje.ErrorIngreso);
                                }
                            }
                        }

                        //Si los datos son iguales que se salte este cartel
                        //Niego su igualdad, osea, si son iguales sigue de largo
                        //pero si son diferentes entra
                        if (!igualHorarios())
                        {
                            if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar los horarios?", "Modificar horarios"))
                            {
                                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                                int retorno = metodos.modificarHorarios(
                                    dtpEntradaSpaMod.Value.ToShortTimeString(), txtEntrada.Text,
                                    dtpEntradaVestMod.Value.ToShortTimeString(), txtEntradaVest.Text,
                                    dtpSalidaSpaMod.Value.ToShortTimeString(), txtSalida.Text,
                                    dtpSalidaVestMod.Value.ToShortTimeString(), txtSalidaVest.Text);

                                if (retorno > 0)
                                {
                                    Mensaje.MostrarInfo("Modificación de horarios de ingreso exitosa", "Modificación de horarios");
                                    cargarHorarios();
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al modificar los horarios", Mensaje.ErrorBD);
                                }
                            }
                        }

                        //Si los datos son iguales que se salte este cartel
                        //Niego su igualdad, osea, si son iguales sigue de largo
                        //pero si son diferentes entra
                        if (!igualServicios())
                        {
                            if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar el precio/duración del servicio " + cmbServicio.SelectedItem.ToString() + "?" + cmbServicio.SelectedText, "Modificar Servicio"))
                            {
                                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
                                int retorno = metodos.modificarPrecioServicio(servicios[cmbServicio.SelectedIndex], Convert.ToInt32(nudPrecServMod.Value), dtpDurServMod.Text);
                                if (retorno > 0)
                                {
                                    Mensaje.MostrarInfo("Modificación de servicio exitosa", "Modificar Servicio");
                                    cargarServicios();
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al modificar el precio/duración del servicio", Mensaje.ErrorBD);
                                }
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

        //Descartar Modificacion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quieres vaciar los campos de modificación?", "Vaciar los campos"))
            {
                cargarPrecios();
                cargarHorarios();
                cargarServicios();
            }
        }

        //Cambiar Precio y Duracion cuando cambia el servicio
        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecServ.Text = servicios[cmbServicio.SelectedIndex].Precio.ToString();
            nudPrecServMod.Value = Convert.ToInt32(servicios[cmbServicio.SelectedIndex].Precio);

            txtDurServ.Text = servicios[cmbServicio.SelectedIndex].Duracion.ToString().Substring(0,5);
            dtpDurServMod.Value = DateTime.Parse(servicios[cmbServicio.SelectedIndex].Duracion.ToString());
        }
    }
}
