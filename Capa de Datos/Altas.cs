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
        /// <returns> Retorna 1 de si exitosa y retonar -1 si ocurrio un error</returns>
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
        /// Pide un objeto persona y lo da de Alta. Rotorna +0 de si lo da de alta o -1 si hay error
        /// </summary>
        public int altaPersona(Persona p)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into persona values({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", p.Ci, p.PrimerNombre, p.SegundoNombre, p.PrimerApellido, p.SegundoApellido, p.Genero, p.FechaNacimiento.ToString("yyyy-MM-dd"), p.Mail, p.Direccion);

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
        /// Da de alta un Telefono(Retorna 1 bien, -1 error)
        /// </summary>
        /// <param name="ciPersona"> Cedula de la Persona</param>
        /// <param name="telefono"> El telefono </param>
        /// <returns> Retorna 1 de si exitosa y retonar -1 si ocurrio un error</returns>
        public int altaTelefono(int ciPersona, String telefono)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into telefono values({0},'{1}');", ciPersona, telefono);

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
                if (ingresoRegistro) nuevoRegistro(sentencia, "Alta de Telefono: " + telefono + " de " + ciPersona);
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

        /// <summary>
        /// Da de alta una reserva y sus Integrantes, retona 1 si fue exitosa y -1 si no
        /// </summary>
        /// <param name="reserva"> El Objeto Reserva</param>
        /// <param name="integrantes"> La lista de Integrantes </param>
        /// <returns>  Retona 1 si fue exitosa y -1 si no</returns>
        public int altaReserva(Reserva reserva, List<Integrantes> integrantes)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("Insert into reserva values(0, {0}, '{1}','{2}','{3}',{4},'{5}','{6}');", reserva.Ci, reserva.Inicio.ToString("yyyy-MM-dd"),
                reserva.Fin.ToString("yyyy-MM-dd"), reserva.TipoDeIngreso, reserva.PrecioTotal, reserva.Estado, reserva.FormaDePago);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                //Doy de Alta la reserva
                MySqlCommand insertReserva = new MySqlCommand(sentencia, conexion.AbrirConexion());
                insertReserva.ExecuteNonQuery();

                //Si hay Integrantes
                if (integrantes.Count > 0)
                {
                    //Consulto el ID de la reserva
                    sentencia = String.Format("select id from reserva where ci={0} and inicio='{1}'", reserva.Ci ,reserva.Inicio.ToString("yyyy-MM-dd"));
                    MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                    MySqlDataReader lector = select.ExecuteReader();

                    int id = -1;
                    if (lector.Read())
                    {
                        id = lector.GetInt32(0);
                    }

                    //Lo cierro para evitar errores
                    lector.Close();
                    
                    //Recorro el Array de Integrantes para darlos de alta
                    foreach (Integrantes integrante in integrantes)
                    {
                        sentencia = String.Format("insert into integran values({0},{1},'{2}');", id, integrante.Ci, integrante.TipoDeIngreso);
                        MySqlCommand insertIntegrantes = new MySqlCommand(sentencia, conexion.AbrirConexion());
                        insertIntegrantes.ExecuteNonQuery();
                    }

                    return 1;
                }

                return 1;
            }
            catch
            {
                //Si hubo un error con el Alta de la Reserva
                //Que la de como candelada Instantaneamente

                ingresoRegistro = false;
                try
                {
                    sentencia = String.Format("update reserva set estado='Cancelada' where ci={0} and inicio='{1}' and estado='{2}';", reserva.Ci, reserva.Inicio.ToString("yyyy-MM-dd"), reserva.Estado);
                    MySqlCommand updateCancelar = new MySqlCommand(sentencia, conexion.AbrirConexion());
                    updateCancelar.ExecuteNonQuery();

                    nuevoRegistro(sentencia, "Error al dar de Alta Reserva(Cancelandola): " + reserva.Ci + " en " + reserva.Inicio.ToString("yyyy-MM-dd"));
                }
                catch { }

                return -1;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();

                if (ingresoRegistro)
                {
                    nuevoRegistro(sentencia, "Alta de Reserva para el cliente: " + reserva.Ci);
                }
            }
        }

        /// <summary>
        /// Da de alta un Servicio a una Reserva
        /// </summary>
        /// <param name="id"> Id de la reserva donde queremos realizar la Reserva</param>
        /// <param name="nombreServicio"> Nombre del servicio a reservar</param>
        /// <param name="inicio"> Fecha de Inicio del Servicio</param>
        /// <param name="fin"> Fecha de Fin del Servicio</param>
        /// <param name="formaDePago"> Forma del Pago del servicio</param>
        /// <returns> Retorna 1/+1 Exito, -1 Error</returns>
        public int altaServicio(int id, String nombreServicio, DateTime inicio, DateTime fin, String formaDePago)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into contiene values({0},'{1}', '{2}','{3}',1,'{4}');", 
                id, nombreServicio, inicio.ToString("yyyy-MM-dd HH:mm"), fin.ToString("yyyy-MM-dd HH:mm"), formaDePago);

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

                if (ingresoRegistro) nuevoRegistro(sentencia, "Alta de Servicio: " + nombreServicio + " en la reserva de Id " + id);
            }
        }
        
        /// <summary>
        /// Da de alta un Empleado
        /// </summary>
        /// <param name="empleado"> El Objeto Empleado</param>
        /// <returns> Retorna 1/+1 Exito, -1 Error</returns>
        public int altaEmpleado(Empleado empleado)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("insert into empleado values ({0}, '{1}', aes_encrypt('{2}','{2}'),'{3}', true);", empleado.Ci, empleado.Usuario,
                empleado.Contra, empleado.Tipo == 1 ? "Gerente" : "Administrativo");

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
                if (ingresarRegistro) nuevoRegistro(sentencia, "Alta de Empleado: " + empleado.Ci);
            }
        }
    }
}
