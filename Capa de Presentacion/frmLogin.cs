using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_Logica;
using Capa_Logica.Clases;

namespace Capa_Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
            //Pongo el icono al form
            this.Icon = Properties.Resources.Logo;
        }

        #region Diseño
        private void txtUsuario_Enter(object sender, EventArgs e)      //Limpia el Campo 
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)   //Vuelve a poner la Indicacion en caso de que el campo este vacio.
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";

            }
        }

        private void txtContra_Enter(object sender, EventArgs e)    //Limpia el campo, hace visible y desmarca el checkbox que muestra la contraseña.
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                chkMostrarContra.Checked = false;
                chkMostrarContra.Visible = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)     //Vuelve a mostrar la indicacion del campo, muestra el texto y oculta el checkbox.
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                chkMostrarContra.Checked = true;
                chkMostrarContra.Visible = false;
            }
        }

        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)       //Hace Legible o no la contraseña
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
        #endregion

        #region Validaciones de Ingreso
        Validaciones validar = new Validaciones();
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "");
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "_ - ? / * # @ % & !");
        }
        #endregion

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("Usuario") && !txtContra.Text.Equals("Contraseña"))
            {
                try
                {
                    int rol = Empleado.Loguearse(txtUsuario, txtContra);
                    if(rol >= 0)
                    {
                        //Le envio que usuario ingreso y que rol tiene
                        frmPrincipal formPrincipal = new frmPrincipal(txtUsuario.Text, rol);
                        //Oculta el login
                        this.Hide();
                        //Muestra el Menu
                        formPrincipal.ShowDialog();
                        //Cuando se cierra el Menu se muestra el login nuevamente
                        this.Show();

                        //Se ponen los componentes como estaban predeterminadamente
                        txtUsuario.Text = "Usuario";
                        txtContra.Text = "Contraseña";
                        chkMostrarContra.Visible = false;
                        chkMostrarContra.Checked = true;
                    }
                    else if(rol == -1)
                    {
                        Mensaje.MostrarError("Usuario y/o Contraseña Incorrecta", Mensaje.ErrorIngreso);
                    }

                }
                catch(Exception ex)
                {
                    Mensaje.MostrarError("Ocurrio un error al iniciar sesion", Mensaje.ErrorBD);
                }
            }
            else
            {
                Mensaje.MostrarError("Complete los Campos", Mensaje.ErrorIngreso);
            }

        }

    }
}
