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
        private static Conexion conexion = new Conexion("login");

        /// <summary>
        /// Verifica si existe un usuario 
        /// </summary>
        /// <param name="usuario"> El nombre del usuario</param>
        /// <param name="contra"> La contrasenia del usuario</param>
        /// <returns> Retorna el tipo de rol que tiene el usuario(-1 o -2 son errores)</returns>
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
    }
}
