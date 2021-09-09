using Capa_Entidades;
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
        private Conexion conexion;
        private readonly int ci;
        public Altas(int rol, int ci)
        {
            this.conexion = new Conexion(rol);
            this.ci = ci;
        }

        /// <summary>
        /// Se agrega un nuevo registro
        /// </summary>
        /// <param name="ci"> La cedula del Empleado que realizo el registro</param>
        /// <param name="sentenciaIngresada"> Sentencia que ejecuto</param>
        /// <param name="descripcion"> Descripcion de la sentencia que se ejecuto</param>
        /// <returns></returns>
        public int NuevoRegistro(String sentenciaIngresada, String descripcion)
        {
            try
            {
                //Creo la sentencia de insert
                String sentencia = String.Format("insert into registrodecambio(ci,sentencia,descripcion) values({0},'{1}','{2}');", ci.ToString(), sentenciaIngresada, descripcion);
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

        public int AltaCliente(Cliente cliente)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("");

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresarRegistro = true;

            try
            {
                MySqlCommand insert = new MySqlCommand(sentencia, conexion.AbrirConexion());
                return insert.ExecuteNonQuery();
            }
            catch
            {
                ingresarRegistro = false;
                return -1;
            }
            finally
            {
                conexion.CerrarConexion();
                if(ingresarRegistro) NuevoRegistro(sentencia, "Alta del cliente: " + cliente.Ci);
            }
        }
    }
}
