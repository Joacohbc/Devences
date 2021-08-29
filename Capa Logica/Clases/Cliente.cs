using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica.Clases
{
    public class Cliente : Persona
    {
        private bool estado;
        private DateTime fechaRegistro;

        #region Constructores
        public Cliente() : base()
        {
            //Instacio los telefonos para que no sea null
            Telefonos = new List<string>();

            //Predeterninadamente esta dado de alta
            estado = true;
        }
        #endregion

        #region Getters y Setters
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        #endregion

        #region Dar de Alta
        public static bool DarAlta(TextBox txtCedula, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido, 
            TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos, ErrorProvider errorProvider)
        {
            //Valida la cedula
            if (Cliente.ValidarCedula(txtCedula, errorProvider))
            {
                //Valido Primer nombre
                if (Cliente.ValidarPrimerNombre(txtPrimerNombre, errorProvider))
                {
                    //Valido segundo nombre
                    if (Cliente.ValidarSegundoNombre(txtSegundoApellido, errorProvider))
                    {
                        //Valido primer apellido
                        if (Cliente.ValidarApellido(txtPrimerNombre, 1, errorProvider))
                        {
                            //Valido segundo apellido(Opcional)
                            if (Cliente.ValidarApellido(txtSegundoApellido, 2, errorProvider))
                            {
                                //Valido mail(Opcional)
                                if (Cliente.ValidarMail(txtMail, errorProvider))
                                {
                                    //Valido direccion
                                    if (Cliente.ValidarDireccion(txtDireccion, errorProvider))
                                    {
                                        //Valido fecha de nacimiento
                                        if (Cliente.ValidarFechaNacimiento(dtpNacimiento, errorProvider))
                                        {
                                            Cliente cliente = CreacionObjeto.CrearCliente(txtCedula, txtPrimerApellido, txtSegundoNombre,
                                                txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos);

                                            //AQUI DEBERIA IR EL DAR DE ALTA
                                            //Y SE SE DIO DE ALTA EXITOSAMENTE RETORNE TRUE

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
        #endregion
    }
}
