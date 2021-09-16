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

        #region Ejemplo 
        /*
        public int ejemplo(Ejemplo ej)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("");

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand nombre = new MySqlCommand(sentencia, conexion.AbrirConexion());
            }
            catch
            {
                ingresoRegistro = false;
                return -1;
            }
            finally
            {
                conexion.CerrarConexion();
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) nuevoRegistro(sentencia, "");
            }
        }
        */
        #endregion 
        /// <summary>
        /// Se agrega un nuevo registro
        /// </summary>
        /// <param name="ci"> La cedula del Empleado que realizo el registro</param>
        /// <param name="sentenciaIngresada"> Sentencia que ejecuto</param>
        /// <param name="descripcion"> Descripcion de la sentencia que se ejecuto</param>
        /// <returns></returns>
        public int nuevoRegistro(String sentenciaIngresada, String descripcion)
        {
            try
            {
                //Creo la sentencia de insert
                //Esta entre comilla la parte de sentencia para que SQL la detecte como Texto sin tomar encuenta las comillas simples ni las comas
                String sentencia = String.Format("insert into registrodecambio(ci,sentencia,descripcion) values({0},\"{1}\",'{2}');", ci.ToString(), sentenciaIngresada, descripcion);
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
                if (ingresoRegistro) nuevoRegistro(sentencia, "Busqueda de Persona: " + ci);
            }
        }

        /// <summary>
        /// Pide un objeto persona y lo da de Alta. Rotorna +0 de si lo da de alta o -1 si hay error
        /// </summary>
        public int altaPersona(Persona p)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into persona values({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                p.Ci, p.PrimerNombre, p.SegundoNombre, p.PrimerApellido, p.SegundoApellido, p.Genero ,p.FechaNacimiento.ToString("yyyy-MM-dd"), p.Mail, p.Direccion);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand insert = new MySqlCommand(sentencia, conexion.AbrirConexion());
                return insert.ExecuteNonQuery();
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
                if (ingresoRegistro) nuevoRegistro(sentencia, "Alta de Persona: " + p.Ci);
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
                if (ingresoRegistro) nuevoRegistro(sentencia, "Busqueda de Cliente: " + ci);
            }
        }

        /// <summary>
        /// Pide un objeto Cliente y lo da de Alta. Rotorna +0 de si lo da de alta o -1 si hay error
        /// </summary>
        public int altaCliente(Cliente cliente)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into cliente(ci) value({0});", cliente.Ci);

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
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresarRegistro) nuevoRegistro(sentencia, "Alta del cliente: " + cliente.Ci);
            }
        }
    }
}
