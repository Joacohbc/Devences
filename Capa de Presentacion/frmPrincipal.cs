using Capa_de_Datos;
using Capa_Entidades;
using Capa_Logica;
using Capa_Logica.Clases;
using Capa_Presentacion.Formularios;
using Capa_Presentacion.Formularios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmPrincipal : Form
    {
        //En esta variable de tipo Empleado se almacena el 
        //empleado que esta usando la sesion
        private static Empleado empleado;

        public frmPrincipal(string usuario, int rol)
        {
            InitializeComponent();

            //Pongo el icono al form
            Icon = Properties.Resources.Logo;

            //Si es admnistrador desactivo los menus a los cuales 
            //no puede acceder
            if (rol == 0)
            {
                btnMenuGerente.Enabled = false;
                pnSubMenuGerente.Enabled = false;
                btnMenuGerente.Visible = false;
                pnSubMenuGerente.Visible = false;
            }

            //Para que se guarde el usuario que inicio sesion
            empleado = MetodosEmpleado.BuscarUsuario(usuario, rol);

            ///Si es null, sigmifca que ocurrio un error
            if (empleado == null)
            {
                Mensaje.MostrarError("Ocurrio un error al cargar al usuario de la sesion", Mensaje.ErrorBD);
                Close();
            }

            //Cargo el label con su nombre de usuario
            lblUsuario.Text = empleado.Usuario;

        }

        //Metodo para Mostrar Sub Menus
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Metodo Para Mostrar Formularios
        private void AbrirFormularios<Forms>() where Forms : Form, new()
        {      //Metodo Generico con Herencia y Constructor Vacio que crea
               //instancias de formularios y los agrega a la coleccion

            Form formulario = pnForms.Controls.OfType<Forms>().FirstOrDefault(); //Buscamos en la coleccion al formulario

            if (formulario == null)                                              //si no existe lo crea
            {
                formulario = new Forms();
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.TopLevel = false;
                pnForms.Controls.Add(formulario);
                pnForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(ColorCerrarForms);
            }
            else
            {                                                               //si ya existe lo trae al frente
                formulario.BringToFront();
            }

        }

        //Metodo para Devolverle el Color a los Botones
        private void ColorCerrarForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["frmInfoReservas"] == null)
                btnConsultas.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmPreciosYHorarios"] == null)
                btnInfoPyH.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmRegClientes"] == null)
                btnRegCli.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmModClientes"] == null)
                btnModifCli.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmRegReservas"] == null)
                btnIngRes.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmModifReservas"] == null)
                btnModifRes.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmRegServicios"] == null)
                btnRegServ.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmModifServicios"] == null)
                btnModifServ.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmRegEmpleados"] == null)
                btnRegEmp.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmModifEmpleados"] == null)
                btnModifEmp.BackColor = Color.PowderBlue;
            if (Application.OpenForms["frmModifHorariosYPrecios"] == null)
                btnModifPyH.BackColor = Color.PowderBlue;

        }

        //Metodo para Confirmacion de Cerrar
        private void ConfirmarCerrarForms(Form formulario)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere cerrar esta pestaña? Puede contener trabajo dentro.", "Cerrar"))
            {
                formulario.Close();
            }
            else
            {
                this.Close();
            }
        }

        //Eventos de Botones de los SubMenus
        #region Eventos de Botones de los SubMenus
        private void btnInfoPyH_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmPreciosYHorarios>();
            btnInfoPyH.BackColor = Color.SkyBlue;
        }

        private void btnInfoRes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmInfoReservas>();
            btnConsultas.BackColor = Color.SkyBlue;
        }

        private void btnRegCli_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmRegClientes>();
            btnRegCli.BackColor = Color.SkyBlue;
        }

        private void btnModifCli_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmModClientes>();
            btnModifCli.BackColor = Color.SkyBlue;
        }

        private void btnIngRes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmRegReservas>();
            btnIngRes.BackColor = Color.SkyBlue;
        }

        private void btnModifRes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmModifReservas>();
            btnModifRes.BackColor = Color.SkyBlue;
        }

        private void btnRegServ_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmRegServicios>();
            btnRegServ.BackColor = Color.SkyBlue;
        }

        private void btnModifServ_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmModifServicios>();
            btnModifServ.BackColor = Color.SkyBlue;
        }

        private void btnRegEmp_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmRegEmpleados>();
            btnRegEmp.BackColor = Color.SkyBlue;
        }

        private void btnModifEmp_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmModifEmpleados>();
            btnModifEmp.BackColor = Color.SkyBlue;
        }

        private void btnModifPyH_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmModifHorariosYPrecios>();
            btnModifPyH.BackColor = Color.SkyBlue;
        }

        #endregion   //Eventos de los Botones de los SubMenus

        //Eventos de los Botones del Menu
        #region Eventos de Botones del Menu
        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSubMenuInfo);
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSubMenuClientes);
        }

        private void btnMenuReservas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSubMenuReservas);
        }

        private void btnMenuServicios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSubMenuServicios);
        }

        private void btnMenuGerente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSubMenuGerente);
        }


        #endregion  //Eventos de los Botones del Menu

        //Metodo para Minimizar/Expandir Menu
        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Visible == false)
            {

                pnMenu.Visible = true;
                btnMinimizarMenu.Image = Properties.Resources.menuLateralInvertido;

            }
            else if (pnMenu.Visible == true)
            {

                pnMenu.Visible = false;
                btnMinimizarMenu.Image = Properties.Resources.menuLateral;
            }
        }

        private bool cerrar = false;
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Application.Exit();
            }
            else
            {
                if (cerrar)
                {
                    if (Mensaje.MostraPreguntaSiNo("Quieres Cerrar Sesion? El trabajo no guardado se perdera", "Cerrar Sesion"))
                    {
                        this.Dispose(true);

                    }
                    else
                    {
                        cerrar = false;
                        e.Cancel = true;
                    }
                }
                else
                {
                    cerrar = false;
                    if (Mensaje.MostraPreguntaSiNo("Quieres Cerrar El Programa? El trabajo no guardado se perdera", "Cerrar Programa"))
                    {
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrar = true;  //Para que cumpla la condicion 
            Close();
        }
    }

}
