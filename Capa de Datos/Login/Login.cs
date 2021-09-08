using Capa_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos.Login
{
    /// <summary>
    /// En esta clase esta el metodo que permite loguearse a los empleados/usuarios
    /// </summary>
    public class Login
    {
        //Instacion un objeto de tipo conexion, para el usuario 'login' (EN LA BD) 
        private static Conexion conexion = new Conexion(2);

        /// <summary>
        /// Verifica si existe un usuario y retornar su rol 0-Administrativo y 1-Gerente
        /// </summary>
        /// <param name="usuario"> El nombre del usuario</param>
        /// <param name="contra"> La contrasenia del usuario</param>
        /// <returns> Retorna el tipo de rol que tiene el usuario,(-1 o -2 son errores)</returns>
        public static int Loguearse(String usuario, String contra)
        {
            try
            {
                MySqlCommand select = new MySqlCommand(String.Format("select tipo from empleado where usuario='{0}' and contra=aes_encrypt('{1}','{1}');", usuario, contra), conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                //Uso IF en vez de While porque el select solo retornara una o ninguna, ya que usuariio es UNIQUE
                if (lector.Read())
                {
                    if (lector.GetString(0) == "Gerente")
                    {
                        //Si es de tipo gerente retornara 1
                        lector.Close();
                        return 1;
                    }
                    else
                    {
                        //Si es de tipo administrativo retornara 0
                        lector.Close();
                        return 0;
                    }
                }
                else
                {
                    //Retorna -1 si no se encontro
                    lector.Close();
                    return -1;
                }
            }
            catch
            {
                //Retrona -2 cuando hay un error
                return -2;
            }
            finally
            {
                //Se cierra en el finally para que simpre se cierre
                //haya ocurrido un error o no hay aocurridos
                //para evitar abrir 2 veces la misma conexion
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Este metodo se le pide el usuario y retorna un objeto Empleado con todos los datos(menos las contrasenia), en caso
        /// de errror retorna null
        /// </summary>
        /// <param name="usuario"> El usuario del Empleado que se quiere</param>
        /// <returns> El Objeto empleado cargado o Null si hay un error</returns>
        public static Empleado BuscarEmpleado(String usuario)
        {
            Empleado empleado = new Empleado();
            try
            {
                //Creo la sentencia de insert
                //Pide todo menos la contrasenia
                String sentencia = String.Format(
                    "select p.ci, usuario, tipo, estado, primerNombre, segundoNombre, primerApellido, segundoApellido, genero, fechaNacimiento, mail, direccion " +
                    "from empleado e join persona p on e.ci=p.ci where e.usuario='{0}';", usuario);
                //Creo el comando
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                //Lo ejecuto
                MySqlDataReader lector = select.ExecuteReader();

                //No hago nada por si no existe
                //Porque el que el usuario exista
                //Ya se determina en el login
                //Osea debe existir para llegar hasta aqui

                //Cargar los datos
                if (lector.Read())
                {
                    //Cargo los datos dentro del objeto
                    empleado.Ci = lector.GetInt32(0);
                    empleado.Usuario = lector.GetString(1);
                    empleado.Tipo = lector.GetString(2);
                    empleado.Estado = lector.GetBoolean(3);
                    empleado.PrimerNombre = lector.GetString(4);
                    empleado.SegundoNombre = lector.GetString(5);
                    empleado.PrimerApellido = lector.GetString(6);
                    empleado.SegundoApellido = lector.GetString(7);
                    empleado.Genero = lector.GetString(8);
                    empleado.FechaNacimiento = lector.GetDateTime(9);
                    empleado.Mail = lector.GetString(10);
                    empleado.Direccion = lector.GetString(11);
                }

                //Retorno el objeto
                return empleado;
            }
            catch
            {
                //Si tira error devuelve null
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
    }
}
