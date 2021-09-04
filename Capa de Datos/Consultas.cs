using Capa_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Consultas
    {
        private static String rol;
        public static string Rol { get => rol; set => rol = value; }

        private static Conexion conexion = new Conexion(rol);

        /// <summary>
        /// Este metodo se le pide el usuario y retorna un objeto Empleado con todos los datos(menos las contrasenia)
        /// </summary>
        /// <param name="usuario"> El usuario del Empleado que se quiere</param>
        /// <returns></returns>
        public static Empleado BuscarUsuario(String usuario)
        {
            Empleado empleado = new Empleado();
            try
            {
                //Creo la sentencia de insert
                String sentencia = String.Format("select * from empleado where usuario={0}", usuario);
                //Creo el comando
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                //Lo ejecuto
                MySqlDataReader lector = select.ExecuteReader();
                
                //Cargar los datos
                if (lector.Read())
                {
                    //FALTAN
                    //CARGAR 
                    //LOS DATOS
                }

                return empleado;
            }
            catch
            {
                //Si tira error devuelve -1
                return empleado;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

    }
}
