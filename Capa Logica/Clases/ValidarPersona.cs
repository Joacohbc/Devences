using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica.Clases
{
    public class ValidarPersona
    {
        #region Validar Campos
        /// <summary>
        /// Valida que una cedula sea valida
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public static bool ValidarCedula(String cedula)
        {
            Validaciones validar = new Validaciones();
            if (validar.validarDigitos(cedula, 13, false, "") == 0)
            {
                if (cedula.Length <= 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida que una cedula sea valida, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarCedula(TextBox txtCi, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarDigitos(txtCi.Text, -1, false, "");

            error.SetIconPadding(txtCi, 5);
            if (validacion == 0)
            {
                if (txtCi.Text.Length == 8)
                {
                    error.SetError(txtCi, "");
                    return true;
                }
                else
                {
                    error.SetError(txtCi, "El campo de la cedula debe tener 8 caracteres");
                    txtCi.Focus();
                    return false;
                }
            }
            //Si esta vacia
            else if (validacion == -1)
            {
                error.SetError(txtCi, "El campo de la cedula no puede estar vacio");
                txtCi.Focus();
                return false;
            }
            else
            {
                error.SetError(txtCi, "El campo de la cedula solo pueden tener numeros(sin espacios)");
                txtCi.Focus();
                return false;
            }
        }

        /// <summary>
        /// Valida que el primer nombre sean validos, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarPrimerNombre(TextBox txtNombre, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetras(txtNombre.Text, 20, true, "");

            error.SetIconPadding(txtNombre, 5);
            if (validacion == 0)
            {
                error.SetError(txtNombre, "");
                return true;
            }
            else if (validacion == -1)
            {
                error.SetError(txtNombre, "El campo del primer nombre no puede estar vacio");
                txtNombre.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                error.SetError(txtNombre, "El campo del primer nombre no puede tener mas de 20 caracteres");
                txtNombre.Focus();
                return false;
            }
            else
            {
                error.SetError(txtNombre, "El campo del primer nombre solo pueden tener letras");
                txtNombre.Focus();
                return false;
            }
        }

        /// <summary>
        /// Valida que el primer nombre sean validos, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarSegundoNombre(TextBox txtNombre, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetras(txtNombre.Text, 20, true, "");

            error.SetIconPadding(txtNombre, 5);
            if (validacion == 0)
            {
                error.SetError(txtNombre, "");
                return true;
            }
            else if (validacion == -1)
            {
                //Si esta vacio se retorna true porque el segundo nombre no es obligatorio
                return true;
            }
            else if (validacion == -2)
            {
                error.SetError(txtNombre, "El campo del segundo nombre no puede tener mas de 20 caracteres");
                txtNombre.Focus();
                return false;
            }
            else
            {
                error.SetError(txtNombre, "El campo del segundo nombre solo pueden tener letras");
                txtNombre.Focus();
                return false;
            }

        }
       
        /// <summary>
        /// Valida que el nombre y segudo apellidos sean validos, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        /// <param name="apellido">Si es 1, los errores mostraran el mensaje de erorr para
        /// el primer apellido, sino lo mostraran para el segundo apellido </param>
        public static bool ValidarApellido(TextBox txtApellido, byte apellido, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetras(txtApellido.Text, 20, true, "");

            //Si se ingres 1, los mensajes mostraran "primer apellido" sino "segundo apellido"
            string apellidoElegido = (apellido == 1 ? "primer apellido" : "segundo apellido");

            error.SetIconPadding(txtApellido, 5);
            if (validacion == 0)
            {
                error.SetError(txtApellido, "");
                return true;
            }
            else if (validacion == -1)
            {
                error.SetError(txtApellido, "El campo del primer apellido no puede estar vacio");
                txtApellido.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                error.SetError(txtApellido, "El campo del " + apellidoElegido + " no puede tener mas de 20 caracteres");
                txtApellido.Focus();
                return false;
            }
            else
            {
                error.SetError(txtApellido, "El campo del " + apellidoElegido + " solo pueden tener letras");
                txtApellido.Focus();
                return false;
            }
        }

        /// <summary>
        /// Valida que la direccion sea valida, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarDireccion(TextBox txtDireccion, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetrasDigitos(txtDireccion.Text, 250, true, ". //");

            error.SetIconPadding(txtDireccion, 5);
            if (validacion == 0)
            {
                error.SetError(txtDireccion, "");
                return true;
            }
            else if (validacion == -1)
            {
                error.SetError(txtDireccion, "El campo de la direccion no puede estar vacio");
                txtDireccion.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                error.SetError(txtDireccion, "El campo de la direccion no puede tener mas de 250 caracteres");
                txtDireccion.Focus();
                return false;
            }
            else
            {
                error.SetError(txtDireccion, "El campo de la direccion solo pueden tener letras, numeros, puntos y barra");
                txtDireccion.Focus();
                return false;
            }
        }

        /// <summary>
        /// Valida que una mail sea valida, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarMail(TextBox txtEmail, ErrorProvider error)
        {
            error.SetIconPadding(txtEmail, 5);
            if (!String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (txtEmail.Text.Length <= 320)
                {
                    if (new EmailAddressAttribute().IsValid(txtEmail.Text))
                    {
                        return true;
                    }
                    else
                    {
                        error.SetError(txtEmail, "El formato del mail ingresado es invalido");
                        txtEmail.Focus();
                        return false;
                    }
                }
                else
                {
                    error.SetError(txtEmail, "El campo del mail no puede tener más de 320 caracteres");
                    txtEmail.Focus();
                    return false;
                }
            }
            else
            {
                //Si esta vacio se retorna true porque el segundo nombre no es obligatorio
                return true;
            }
        }

        /// <summary>
        /// Valida que la fecha de nacimiento sea menor al dia actual, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarFechaNacimiento(DateTimePicker dtpFechaNacimiento, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            //Pone la efcha en el formato dd/mm/yyyy
            DateTime fecha = DateTime.Parse(dtpFechaNacimiento.Value.ToShortDateString());

            error.SetIconPadding(dtpFechaNacimiento, 5);
            if (validar.validarFechaPrimeraEsMenor(fecha, DateTime.Now))
            {
                return true;
            }
            else
            {
                error.SetError(dtpFechaNacimiento, "La fecha de nacimiento debe ser menor al dia actual");
                dtpFechaNacimiento.Focus();
                return false;
            }
        }

        /// <summary>
        /// Valida que el telefono sea valido, y mostrar el error, si hay, en un ErrorProvider
        /// </summary>
        public static bool ValidarTelefono(TextBox txtTelefono, ErrorProvider error)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarDigitos(txtTelefono.Text, 21, true, "+ -");

            error.SetIconPadding(txtTelefono, 5);
            if (validacion == 0)
            {
                error.SetError(txtTelefono, "");
                return true;
            }
            else if (validacion == -1)
            {
                error.SetError(txtTelefono, "El campo del telefono no puede estar vacio");
                txtTelefono.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                error.SetError(txtTelefono, "El campo del telefono no puede tener mas de 21 caracteres");
                txtTelefono.Focus();
                return false;
            }
            else
            {
                error.SetError(txtTelefono, "El campo del telefono solo pueden tener numeros, signos de mas y signos de menos");
                txtTelefono.Focus();
                return false;
            }
        }
        #endregion
    }
}
