using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_de_Datos.Login;

namespace Capa_Logica.Clases
{
    public class Empleado : Persona
    {
        private string usuario;
        private string contra;
        private string tipo;
        private bool estado;

        #region Constructores
        public Empleado() : base()
        {
            Telefonos = new List<string>();
            estado = true;
        }
        #endregion

        #region Getters y Setters
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Estado { get => estado; set => estado = value; }
        #endregion

        #region Login
        public static int Loguearse(TextBox txtUsuario, TextBox txtContra)
        {
            //Valida el campo de usuario
            if (validarUsuarioYContra(txtUsuario, 0))
            {
                //Valida el campo de contrasenia
                if (validarUsuarioYContra(txtContra, 1))
                {
                    //Retorna el tipo de rol
                    return Login.Loguearse(txtUsuario.Text, txtContra.Text);
                }
                else
                {
                    //Retonar otro numero, da igual, ya que el mensaje de error
                    //Lo muestra este metodo
                    return -3;
                }
            }
            else
            {
                //Retonar otro numero, da igual, ya que el mensaje de error
                //Lo muestra este metodo
                return -3;
            }
        }

        /// <summary>
        /// Valida que un usuario sea valido
        /// </summary>
        /// <param name="txtBox"> El campo que quiere validar</param>
        /// <param name="deQue"> Si es 0, muestra un mensaje de error para el usuario y su es diferente de 0 muestra
        /// un mensaje de error para la contraseña</param>
        /// <returns> True si es valido y false si no lo es</returns>
        private static bool validarUsuarioYContra(TextBox txtBox, int deQue)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetrasDigitos(txtBox.Text.ToLower(), 20, false, "");
            if (validacion == 0)
            {
                return true;
            }
            else if (validacion == -1)
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario no puede estar vacio", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña no puede estar vacio", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario debe tener menos de 20 caracteres", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña debe tener menos de 20 caracteres", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
            else
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario solo puede contener digitos y letras(Sin espacios)", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña solo puede contener digitos y letras(Sin espacios)", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
        }
        #endregion

    }
}
