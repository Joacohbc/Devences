using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_de_Datos.Login;
using Capa_Entidades;

namespace Capa_Logica.Clases
{
    public class MetodosEmpleado
    {
        #region Login

        /// <summary>
        /// Verifica si existe un usuario y retornar su rol 0-Administrativo y 1-Gerente
        /// </summary>
        /// <param name="usuario"> El nombre del usuario</param>
        /// <param name="contra"> La contrasenia del usuario</param>
        /// <returns> Retorna el tipo de rol que tiene el usuario,(-1 o -2 son errores)</returns>
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
        /// Este metodo se le pide el usuario y retorna un objeto Empleado con todos los datos(menos las contrasenia), en caso
        /// de errror retorna null
        /// </summary>
        /// <param name="usuario"> El usuario del Empleado que se quiere</param>
        /// <returns> El Objeto empleado cargado o Null si hay un error</returns>
        public static Empleado BuscarUsuario(String usuario)
        {
            return Login.BuscarEmpleado(usuario);
        }

        /// <summary>
        /// Valida que un usuario sea valido
        /// </summary>
        /// <param name="txtBox"> El campo que quiere validar</param>
        /// <param name="deQue"> Si es 0, muestra un mensaje de error para el usuario y su es diferente de 0 muestra
        /// un mensaje de error para la contraseña</param>
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

        //LOS METODOS DE LOGUEO SON ESTATICOS
        //YA QUE NO NECESITAN NI LA CEDULA NI EL ROL
        //PERO EL RESTO NO LO SON PORQUE SE NECESITA 
        //Y PARA ESO ESTA EL COSNTRUCTOR DE LA CLASE QUE LOS PIDE

        private int ci;
        private int rol;
        private Altas altas;

        public MetodosEmpleado(int ci, int rol)
        {
            this.ci = ci;
            this.rol = rol;
            altas = new Altas(rol, ci);
        }
    
        #region Metodos Clientes

        /// <summary>
        /// Valida un cliente
        /// </summary>
        /// <param> PIde los datos de Cliente</param>
        /// <returns> El Objeto Cliente cargado si es valido sino retorna null</returns>
        public Cliente validarCliente(TextBox txtCedula, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido,
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

                                            return CreacionObjeto.CrearCliente(Convert.ToInt32(txtCedula.Text), txtPrimerApellido, txtSegundoNombre,
                                                                txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos);
                                        }
                                        else
                                        {
                                            return null;
                                        }
                                    }
                                    else
                                    {
                                        return null;
                                    }
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
      
        /// <summary>
        /// Da de alta una Persona
        /// </summary>
        /// <param name="persona"> Un Objeto Persona</param>
        /// <returns> Retorna 1 si la da de Alta, retona 0 si esa persona ya existe en esa tabla y -1 si ocurrio un error</returns>
        public int darAltaPersona(Persona persona)
        {
            //Busco la persona
            int retorno = altas.buscarPersona(persona.Ci);
            if (retorno == 0)
            {
                //Lo intento dar de alta a la Persona
                retorno = altas.altaPersona(persona);
                if (retorno > 0)
                {
                    return 1;
                }
                else
                {
                    //Si ocurrio un error a dar de alta a la persona
                    return -1;
                }
            }
            else if (retorno == 1)
            {
                //Si la persona ya existe
                return 0;
            }
            else
            {
                //Si ocurrio un error al buscar a la persona
                return -1;
            }
        }

        /// <summary>
        /// Da de alta un Cliente
        /// </summary>
        /// <param name="cliente"> Un Objeto Cliente</param>
        /// <returns> Retorna 1 si la da de Alta, retona 0 si esa persona ya existe en esa tabla y -1 si ocurrio un error</returns>
        public int darAltaCliente(Cliente cliente)
        {
            //Busco la persona
            int retorno = altas.buscarCliente(cliente.Ci);
            if (retorno == 0)
            {
                //Lo intento dar de alta a la Cliente
                retorno = altas.altaCliente(cliente);
                if (retorno > 0)
                {
                    return 1;
                }
                else
                {
                    //Si ocurrio un error a dar de alta a la Cliente
                    return -1;
                }
            }
            else if (retorno == 1)
            {
                //Si la Cliente ya existe
                return 0;
            }
            else
            {
                //Si ocurrio un error al buscar a la Cliente
                return -1;
            }
        }

        #endregion
    }
}
