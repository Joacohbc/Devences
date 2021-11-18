using Capa_Entidades;
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

        public int ModificarTelefonos(int ci, List<String> telefonosNuevos)
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

        public int modificarEmpleado(Empleado empleado)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("update empleado set usuario='{1}', contra=aes_encrypt('{2}','{2}'), tipo='{3}' WHERE ci={0};", empleado.Ci, empleado.Usuario ,empleado.Contra, empleado.Tipo == 1 ? "Gerente" : "Administrativo");

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Modificar Empleado: " + empleado.Ci);
            }
        }

        public int modificarPreciosIngreso(int precioNormal, int precioNormalAntes, int precioAlojado, int precioAlojadoAntes, int precioJub, int precioJubAntes)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format(
                "UPDATE parametros SET valor='{0}' WHERE titulo='Ingreso Jubilados/Pensionistas' and valor='{1}'; " +
                "UPDATE parametros SET valor = '{2}' WHERE titulo = 'Ingreso de alojados' and valor = '{3}';" +
                "UPDATE parametros SET valor = '{4}' WHERE titulo = 'Ingreso Normal' and valor = '{5}';",
                precioJub, precioJubAntes,
                precioAlojado, precioAlojadoAntes,
                precioNormal, precioNormalAntes);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Cambio de precios de ingreso");
            }
        }

        public int modificarHorarios(String entradaSpa, String entradaSpaAntes, String entradaVest, String entradaVestAntes, String salidaSpa, String salidaSpaAntes, String salidaVest,
            String salidaVestAntes)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("" +
                "UPDATE parametros SET valor='{0}' WHERE titulo='Horario entrada' and valor='{1}';" +
                "UPDATE parametros SET valor = '{2}' WHERE titulo = 'Horario entrada a vestuarios' and valor = '{3}';" +
                "UPDATE parametros SET valor = '{4}' WHERE titulo = 'Horario salida' and valor = '{5}';" +
                "UPDATE parametros SET valor = '{6}' WHERE titulo = 'Horario salida de vestuarios' and valor = '{7}';",
                entradaSpa, entradaSpaAntes,
                entradaVest, entradaVestAntes,
                salidaSpa, salidaSpaAntes,
                salidaVest, salidaVestAntes);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Modificacion de Horarios");
            }
        }

        public int modificarReserva(DateTime nuevoInicio, DateTime nuevoFin, int nuevoPrecio, String estado, Reserva reserva)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("UPDATE reserva SET inicio='{0}', fin='{1}', precioTotal='{2}', estado='{3}' " +
                                             "WHERE id = '{4}';",
                                             nuevoInicio.ToString("yyyy-MM-dd"), nuevoFin.ToString("yyyy-MM-dd"), nuevoPrecio, estado, 
                                             reserva.Id);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Modificar reserva: " + reserva.Id);
            }
        }
    }
}
