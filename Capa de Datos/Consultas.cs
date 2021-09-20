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

    }
}
