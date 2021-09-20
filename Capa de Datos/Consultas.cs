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
        private Conexion conexion;

        private readonly int ci;
        //Para el alta de un Nuevo Registro
        private Altas altas;

        public Consultas(int rol, int ci)
        {
            this.conexion = new Conexion(rol);
            this.ci = ci;
            this.altas = new Altas(rol, ci);
        }

        /// <summary>
        /// Pide la cedula y busca a la Persona. Retorna 1 si ya existe, 0 si no existe y -1 si hay error
        /// </summary>
        public int buscarPersona(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from persona where ci={0};", ci);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();
                //Leo lo que devuelve
                if (lector.Read())
                {
                    //Retorno 1 si encuentro
                    return 1;
                }
                else
                {
                    //Retorno 0 si no encuentro
                    return 0;
                }
            }
            catch
            {
                ingresoRegistro = false;
                return -1;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Busqueda de Persona: " + ci);
            }
        }

        /// <summary>
        /// Pide la cedula y busca a la Cliente, Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int buscarCliente(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from cliente where ci={0};", ci);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();
                //Leo lo que devuelve
                if (lector.Read())
                {
                    //Retorno 1 si existe
                    return 1;
                }
                else
                {
                    //Retorno 0 si no existe
                    return 0;
                }
            }
            catch
            {
                ingresoRegistro = false;
                return -1;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Busqueda de Cliente: " + ci);
            }
        }

        /// <summary>
        /// Consulta los nombres de los servicios y los retonar en un List
        /// </summary>
        /// <returns> Retorna una lista con los servicios o null si hubo error</returns>
        public List<String> traerServicios()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = "select nombre from servicio;";

            //Creo la lista que voy a retornar
            List<String> servicios = new List<string>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                while (lector.Read())
                {
                    servicios.Add(lector.GetString(0));
                }
                return servicios;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de servicios(Solo Nombres)");
            }
        }

        /// <summary>
        /// Consulta los tipos de de ingreso, sus nombre y precio y los retonar en un List
        /// </summary>
        /// <returns>Un List con los tipos de Ingreso, sino retorna null</returns>
        public List<String> traerTiposDeIngreso()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = "select * from parametros where titulo like('ingreso%')  order by cast(valor as unsigned) desc;";

            //Creo la lista que voy a retornar
            List<String> tiposDeIngreso = new List<string>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                while (lector.Read())
                {
                    tiposDeIngreso.Add(lector.GetString(0) + "($" + lector.GetString(1) + ")");
                }

                return tiposDeIngreso;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de Tipos de Ingresos");
            }
        }
    }
}
