﻿using Capa_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Modificaciones
    {

        private Conexion conexion;

        private readonly int ci;

        //Para el alta de un Nuevo Registro
        private Altas altas;

        public Modificaciones(int rol, int ci)
        {
            this.conexion = new Conexion(rol);
            this.ci = ci;
            this.altas = new Altas(rol, ci);
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
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) nuevoRegistro(sentencia, "");
            }
        }
        */
        #endregion

        public int ModificarPersona(Persona p)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("update persona set primerNombre='{1}', segundoNombre='{2}',genero='{3}', mail='{4}', direccion='{5}' where ci='{0}';", 
                p.Ci,p.PrimerNombre,p.SegundoNombre,p.Genero,p.Mail,p.Direccion);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand update = new MySqlCommand(sentencia, conexion.AbrirConexion());
                return update.ExecuteNonQuery();
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

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Modificacion del cliente: " + p.Ci);
            }
        }

        public int BorrarTelefonos(int ci, List<String> telefonosNuevos)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("delete from telefono where ci={0};", ci);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand update = new MySqlCommand(sentencia, conexion.AbrirConexion());
                update.ExecuteNonQuery();

                foreach(String telefono in telefonosNuevos)
                {
                    altas.altaTelefono(ci, telefono);
                }

                return 1;
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

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Se modificaron los numeros del cliente: " + ci);
            }

        }

        public int ModificarEstadoCliente(int ci, bool estado)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("update cliente set estado='{1}' where ci='{0}';",
                ci, estado);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand update = new MySqlCommand(sentencia, conexion.AbrirConexion());
                return update.ExecuteNonQuery();
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

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Modificacion estado del cliente: " + ci + " Estado=" + estado);
            }
        }
    }
}