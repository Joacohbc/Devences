using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica.Clases
{
    public class MetodosCliente
    {
        #region Dar de Alta
        public static bool DarAlta(TextBox txtCedula, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido, 
            TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos, ErrorProvider errorProvider)
        {
            //Valida la cedula
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                //Valido Primer nombre
                if (ValidarPersona.ValidarPrimerNombre(txtPrimerNombre, errorProvider))
                {
                    //Valido segundo nombre
                    if (ValidarPersona.ValidarSegundoNombre(txtSegundoApellido, errorProvider))
                    {
                        //Valido primer apellido
                        if (ValidarPersona.ValidarApellido(txtPrimerApellido, 1, errorProvider))
                        {
                            //Valido segundo apellido(Opcional)
                            if (ValidarPersona.ValidarApellido(txtSegundoApellido, 2, errorProvider))
                            {
                                //Valido mail(Opcional)
                                if (ValidarPersona.ValidarMail(txtMail, errorProvider))
                                {
                                    //Valido direccion
                                    if (ValidarPersona.ValidarDireccion(txtDireccion, errorProvider))
                                    {
                                        //Valido fecha de nacimiento
                                        if (ValidarPersona.ValidarFechaNacimiento(dtpNacimiento, errorProvider))
                                        {
                                            Cliente ValidarPersona = CreacionObjeto.CrearCliente(Convert.ToInt32(txtCedula.Text), txtPrimerApellido, txtSegundoNombre,
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
