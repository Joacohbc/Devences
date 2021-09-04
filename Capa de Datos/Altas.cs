using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Altas
    {
        private static String rol;
        public static string Rol { get => rol; set => rol = value; }

        private static Conexion conexion = new Conexion(rol);
        
        /// <summary>
        /// Se agrega un nuevo registro
        /// </summary>
        /// <param name="ci"> La cedula del Empleado que realizo el registro</param>
        /// <param name="sentenciaIngresada"> Sentencia que ejecuto</param>
        /// <param name="descripcion"> Descripcion de la sentencia que se ejecuto</param>
        /// <returns></returns>
        public static int NuevoRegistro(String ci, String sentenciaIngresada, String descripcion)
        {
            try
            {
                //Creo la sentencia de insert
                String sentencia = String.Format("insert into registrodecambio values(0,{0},'{1}','{2}');", ci, sentenciaIngresada, descripcion);
                //Creo el comando
                MySqlCommand insert = new MySqlCommand(sentencia, conexion.AbrirConexion());
                //Lo ejecuto
                return insert.ExecuteNonQuery();
            }
            catch
            {
                //Si tira error devuelve -1
                return -1;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
    }
}
