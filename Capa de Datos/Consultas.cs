using Capa_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Persona: " + ci);
            }
        }

        /// <summary>
        /// Pide la cedula y busca a la Cliente(Si esta dado de Alta), Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int buscarCliente(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from cliente where ci={0} and estado=true;", ci);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Cliente: " + ci);
            }
        }

        /// <summary>
        /// Pide la cedula y busca a la Cliente(Si existe), Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int existeCliente(int ci)
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Cliente (existe): " + ci);
            }
        }

        /// <summary>
        /// Pide la cedula y busca a si tiene telefonos, Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int tieneTelefonos(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from telefono where ci={0};", ci);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar teléfonos: " + ci);
            }
        }

        /// <summary>
        /// Consulta una Persona por su cedula y retonar el objeto Persona, o NUll si hay error
        /// </summary>|
        /// <param name="ci">La cedula de la persona</param>
        /// <returns>Retorna el Objeto Persona, o Null si ocurrio un error</returns>
        public Persona traerPersona(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select p.ci, primerNombre, segundoNombre, primerApellido, segundoApellido, genero, fechaNacimiento, mail, direccion, telefono " +
                "from persona p join telefono t on p.ci = t.ci " +
                "where p.ci={0};", ci);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                Persona persona = new Persona();

                //Si no tiene telefono, que cambie la sentencia
                if (tieneTelefonos(ci) == 0)
                {
                    sentencia = String.Format("select ci, primerNombre, segundoNombre, primerApellido, segundoApellido, genero, fechaNacimiento, mail, direccion " +
                             "from persona where ci={0};", ci);
                    MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                    MySqlDataReader lector = select.ExecuteReader();

                    //Leo lo que devuelve
                    if (lector.Read())
                    {
                        //Retorno 1 si encuentro
                        persona.Ci = lector.GetInt32(0);
                        persona.PrimerNombre = lector.GetString(1);
                        persona.SegundoNombre = lector.GetString(2);
                        persona.PrimerApellido = lector.GetString(3);
                        persona.SegundoApellido = lector.GetString(4);
                        persona.Genero = lector.GetString(5);
                        persona.FechaNacimiento = lector.GetDateTime(6);
                        persona.Mail = lector.GetString(7);
                        persona.Direccion = lector.GetString(8);
                    }
                }
                //Si tiene telefonos
                else
                {
                    MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                    MySqlDataReader lector = select.ExecuteReader();

                    //Leo lo que devuelve
                    while (lector.Read())
                    {
                        //Retorno 1 si encuentro
                        persona.Ci = lector.GetInt32(0);
                        persona.PrimerNombre = lector.GetString(1);
                        persona.SegundoNombre = lector.GetString(2);
                        persona.PrimerApellido = lector.GetString(3);
                        persona.SegundoApellido = lector.GetString(4);
                        persona.Genero = lector.GetString(5);
                        persona.FechaNacimiento = lector.GetDateTime(6);
                        persona.Mail = lector.GetString(7);
                        persona.Direccion = lector.GetString(8);
                        persona.Telefonos.Add(lector.GetString(9));
                    }
                }

                return persona;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de Persona: " + ci);
            }
        }

        public Empleado traerEmpleado(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select * from empleado where ci='{0}';", ci);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                sentencia = String.Format(sentencia, ci);
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                Empleado empleado = new Empleado();
                //Leo lo que devuelve
                if (lector.Read())
                {
                    empleado.Ci = lector.GetInt32(0);
                    empleado.Usuario = lector.GetString(1);
                    empleado.Tipo = lector.GetString(3) == "Gerente" ? 1 : 0;
                    empleado.Estado = lector.GetBoolean(4);
                    return empleado;
                }
                else
                {
                    empleado.Ci = 0;
                    return empleado;
                }

            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de Empleado: " + ci);
            }
        }

        /// <summary>
        /// Consulta los nombres de los servicios y los retonar en un List
        /// </summary>
        /// <returns> Retorna una lista con los servicios o null si hubo error</returns>
        public List<Servicios> traerServicios()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = "select * from servicio;";

            //Creo la lista que voy a retornar
            List<Servicios> servicios = new List<Servicios>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                while (lector.Read())
                {
                    servicios.Add(new Servicios(lector.GetString(0), lector.GetTimeSpan(1), lector.GetInt32(2), lector.GetInt32(3), lector.GetInt32(4)));
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
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de servicios");
            }
        }

        /// <summary>
        /// Consulta los tipos de de ingreso, sus nombre y precio y los retonar en un List
        /// </summary>
        /// <returns>Un List bidimensional con los tipos de Ingreso y el precio, sino retorna null</returns>
        public List<String[]> traerTiposDeIngreso()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro

            //El "order by cast(valor as unsigned) desc" es pasar el VARCHAR a INT para luego ordenarlo decendentemente
            //Asi quedan los precios ordenados
            String sentencia = "select * from parametros where titulo like('ingreso%')  order by cast(valor as unsigned) desc;";

            //Creo la lista que voy a retornar
            List<String[]> tiposDeIngresos = new List<String[]>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                while (lector.Read())
                {
                    String[] tipoDeIngreso = { lector.GetString(0), lector.GetString(1) };
                    tiposDeIngresos.Add(tipoDeIngreso);
                }

                return tiposDeIngresos;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de Tipos de Ingresos");
            }
        }

        /// <summary>
        /// Buscar si existen Reservas(que no este ni Eliminada ni Cancelada ni Finalizada) de un 
        /// cliente con determinada fecha de inicio y retorna el ID de la reserva(Retorna ID, 0 No, -1 error)
        /// </summary>
        /// <param name="ci"> una Cedula </param>
        /// <param name="inicio"> el inicio de la reserva</param>
        /// <returns> 1 o +1 si hay alguna, 0 si no hay ninguna y -1 si ocurrio un error </returns>
        public int buscarIdDeReserva(int ci, DateTime inicio)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select id from reserva where ci={0} and inicio='{1}' and not estado = 'Eliminada' and not estado = 'Cancelada' " +
                "and not estado = 'Finalizada'", ci, inicio.ToString("yyyy-MM-dd"));


            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                //Consulto el ID de la reserva
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                if (lector.Read())
                {
                    //Retorna el ID
                    return lector.GetInt32(0);
                }
                else
                {
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

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de ID de Reserva");
            }
        }

        /// <summary>
        /// Buscar si hay un empleado dado de alta(1 Si, 0 No, -1 error)
        /// </summary>
        /// <param name="ci"> la Cedula</param>
        /// <returns>1 Si, 0 No, -1 error </returns>
        public int buscarEmpleado(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from empleado where ci={0} and estado=true;", ci);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Empleado: " + ci);
            }
        }

        /// <summary>
        /// Buscar si hay un empleado(1 Si, 0 No, -1 error)
        /// </summary>
        /// <param name="ci"> la Cedula</param>
        /// <returns>1 Si, 0 No, -1 error </returns>
        public int existeEmpleado(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select ci from empleado where ci={0};", ci);

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Empleado (existe): " + ci);
            }
        }

        /// <summary>
        /// Buscar si existen Reserva Confirmada de un 
        /// cliente con determinada fecha de inicio y retorna el ID de la reserva(Retorna ID, 0 No, -1 error)
        /// </summary>
        /// <param name="ci"> una Cedula </param>
        /// <param name="inicio"> el inicio de la reserva</param>
        /// <returns> 1 o +1 si hay alguna, 0 si no hay ninguna y -1 si ocurrio un error </returns>
        public int buscarIdDeReservaConfirmada(int ci, DateTime inicio)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select id from reserva where ci={0} and inicio='{1}' and estado = 'Confirmada'", ci, inicio.ToString("yyyy-MM-dd"));

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                //Consulto el ID de la reserva
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                if (lector.Read())
                {
                    //Retorna el ID
                    return lector.GetInt32(0);
                }
                else
                {
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

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de ID de Reserva");
            }
        }

        /// <summary>
        /// Retorna una reserva(da igual el estado), retona la reserva con la CI=-1 si no la encuentra
        /// y retorna null si ocurrio un erro
        /// </summary>
        /// <param name="ci"> La cedula del titular de la reserva</param>
        /// <param name="inicio"> el inicio de la reserva</param>
        /// <returns> Retorna un objeto reserva con todos los datos si se ejcuto correctamente
        /// la sentencia, retorna la reserva con la CI=-1 si no encotro la reserrva
        /// y retorna null si ocurrio un error</returns>
        public Reserva traerReserva(int ci, DateTime inicio)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select * from reserva where ci={0} and inicio='{1}';", ci, inicio.ToString("yyyy-MM-dd"));

            //Creo la lista que voy a retornar
            List<String[]> tiposDeIngresos = new List<String[]>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                Reserva reserva = new Reserva();
                if (lector.Read())
                {
                    reserva.Id = lector.GetInt32(0);
                    reserva.Ci = lector.GetInt32(1);
                    reserva.Inicio = lector.GetDateTime(2);
                    reserva.Fin = lector.GetDateTime(3);
                    reserva.TipoDeIngreso = lector.GetString(4);
                    reserva.PrecioTotal = lector.GetInt32(5);
                    reserva.Estado = lector.GetString(6);
                    reserva.FormaDePago = lector.GetString(7);

                    return reserva;
                }
                else
                {
                    reserva.Ci = -1;
                    return reserva;
                }
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar datos de Reserva: Cliente: " + ci + " Inicio: " + inicio.ToString("yyyy-MM-dd"));
            }
        }

        /// <summary>
        /// Valida que una Reserva no tenga ya ese servicio reservado(Si esta Confirmado), retorna  1 si ya lo tiene, 0 si no
        /// y null si ocurrio une error
        /// </summary>
        /// <param name="nombre"> Nombre del servicio</param>
        /// <param name="ci"> cedula del titular de la reserva </param>
        /// <returns></returns>
        public int servicioYaExiste(String nombre, int ci)
        {
            /*
                SI LA RESERVA YA TIENE ESE SERVICIO DADO DE ALTA(CONFIRMADO) QUE NO 
                SE LO DEJE CONFIRMAR OTRA VEZ
             */

            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select r.id from contiene c join reserva r on c.id = r.id " +
                "where c.nombre = '{0}' and r.ci={1} and c.estado='Confirmada';", nombre, ci);

            //Creo la lista que voy a retornar
            List<String[]> tiposDeIngresos = new List<String[]>();

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                Reserva reserva = new Reserva();
                if (lector.Read())
                {
                    return 1;
                }
                else
                {
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar si ya existe un servicio");
            }
        }

        /// <summary>
        /// Traer todos los horarios desde la base de datos, y Null si ocurrio un error
        /// </summary>
        /// <returns> Retonarna una Lista de horarios</returns>
        public List<String> traerHorarios()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = "select valor from parametros where titulo like('Horario%'); ";

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                List<String> horarios = new List<string>();
                while (lector.Read())
                {
                    horarios.Add(lector.GetString(0));
                }

                return horarios;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de horarios");
            }
        }

        /// <summary>
        /// Traer los integrantes de una reserva, si tiene.Si hay error envia Null
        /// </summary>
        /// <param name="id"> El ID de la Reserva de los integrantes</param>
        /// <returns> Retorna un List de Integratnes, en caso de rror tira Null</returns>
        public List<Integrantes> traerIntegrantes(int id)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select * from integran where id = '{0}';", id);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                List<Integrantes> integrantes = new List<Integrantes>();
                while (lector.Read())
                {
                    Integrantes integrante = new Integrantes(lector.GetInt32(1), lector.GetString(2));
                    integrantes.Add(integrante);
                }
                return integrantes;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar datos de Integrantes: Cliente: " + ci);
            }
        }

        public List<String[]> traerServiciosDeUnaReserva(int id)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("SELECT nombre, inicio, fin FROM contiene where id='{0}' and estado='Confirmada';", id);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                List<String[]> servicios = new List<string[]>();
                while (lector.Read())
                {
                    String[] servicio = { lector.GetString(0), lector.GetString(1), lector.GetString(2) };
                    servicios.Add(servicio);
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
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar servicios de la Reserva: " + id);
            }
        }

        public int clienteEnReserva(int ci)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select count(i.ci) " +
                "from reserva r join integran i " +
                "on i.ci=r.ci or r.id=i.id " +
                "where r.ci='{0}' and r.estado not in('Eliminada','Cancelada','Finalizada');", ci);

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
                    return lector.GetInt32(0);
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Búsqueda de Cliente en alguna reserva: " + ci);
            }
        }

        #region Consultras de Reserva Avanzadas

        /// <summary>
        /// Comprueba si un dia indicado de ya esta reservado por determinado cliente
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="dia"></param>
        /// <returns> 1 si el dia ya esta reservado, 0 si no lo esta y -1 si ocurrio un error</returns>
        public int comprobarDiaEnReserva(int ci, DateTime dia)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("call comprobarDiaEnReserva('{0}',{1});",
                dia.ToString("yyyy-MM-dd"), ci);

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
                    //Retorno ese dia esta reservado
                    return 1;
                }
                else
                {
                    //Retorno 0 si no esta reservado
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta si un dia pertenece a una reserva: " + dia.ToString("yyyy-MM-dd") + " Reservas de:" + ci);
            }
        }

        /// <summary>
        /// Comprueba si un dia indicado de ya esta reservado en todas algunas de sus reservas(quitando la de el id
        /// indiciado) por determinado cliente
        /// </summary>
        /// <param name="ci"> CI del cliente</param>
        /// <param name="id"> Id de la reserva a ignorar</param>
        /// <param name="dia"> Dia que quiero tomar en cuenta</param>
        /// <returns> Retorna 1 si tiene la reserva, y 0 sino la tiene, y -1 si hay error</returns>
        public int comprobarDiaEnReservaAModificar(int ci, int id, DateTime dia)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select id from reserva where ('{0}' between inicio and fin) and ci={1} and id != '{2}' " +
                "and estado not in ('Eliminada', 'Finalizada', 'Cancelada');",
                dia.ToString("yyyy-MM-dd"), ci, id);

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
                    //Retorno la cantidad de reservas
                    return 1;
                }
                else
                {
                    //Retorno 0 si no hay ninguna reserva
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta si un dia pertenece a una reserva(quitando el id=" + id + "): " + dia.ToString("yyyy-MM-dd") + " Reservas de:" + ci);
            }
        }

        /// <summary>
        /// Comprueba al cantidad de servicios que tiene una reserva
        /// </summary>
        /// <param name="id"> El id de la reserva</param>
        /// <returns> Retorna la cantidad de servicios, 0 si no hay servicios y -1 si hay error </returns>
        public int comprobarCantidadServiciosEnReserva(int id)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select count(id) from contiene where id = '{0}' and estado = 'Confirmada';", id);

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
                    //Retorno la cantidad de servicios
                    return lector.GetInt32(0);
                }
                else
                {
                    //Retorno 0 si no hay ningun servicio
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Compruebo servicios de la reserva: " + id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public int cantidadDePersonasPorServicio(DateTime fechaInicio, DateTime fechaFin, String nombre)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("call MaxPersonasServicio('{0}', '{1}', '{2}');",
                fechaInicio.ToString("yyyy-MM-dd HH:mm:ss"), fechaFin.ToString("yyyy-MM-dd HH:mm:ss"), nombre);


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
                    //Retorno la cantidad de reservas
                    return lector.GetInt32(0);
                }
                else
                {
                    //Retorno 0 si no hay ningun servicio
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de cantidad personas en servicio: " + ci);
            }
        }
        #endregion


        #region Consultas para el apartado de Consultas

        private DataTable realizarConsulta(String sentencia, String mensajeRegistro)
        {
            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                DataTable dt = new DataTable();
                dt.Load(select.ExecuteReader());
                return dt;
            }
            catch
            {
                ingresoRegistro = false;
                return null;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, mensajeRegistro);
            }
        }

        public DataTable verTodosLosClientesActivos()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = @"select p.ci 'Cédula', primerNombre 'Nombre', primerApellido 'Primer Apellido', segundoApellido 'Segudo Apellido', 
                genero 'Género', fechaNacimiento 'Nacimiento', mail 'Mail', direccion 'Dirección' 
                from persona p join cliente c 
                on p.ci = c.ci 
                where c.estado = true;";

            return realizarConsulta(sentencia, "Consultar todos los clientes activos");
        }

        public DataTable verTodosLosClientesInactivos()
        {
            String sentencia = @"select p.ci 'Cédula', primerNombre 'Nombre', primerApellido 'Primer Apellido', segundoApellido 'Segudo Apellido',
                genero 'Género', fechaNacimiento 'Nacimiento', mail 'Mail', direccion 'Dirección' 
                from persona p join cliente c 
                on p.ci = c.ci 
                where c.estado = false;";

            return realizarConsulta(sentencia, "Consultar todos los clientes inactivos");
        }

        public DataTable verTodasLasReservas()
        {
            String sentencia = @"
                select id 'Id Reserva', r.ci 'Titular', p.primerNombre 'Nombre', p.primerApellido 'Apellido',inicio 'Inicio', 
                fin 'Fin', tipoDeIngreso 'Ingreso del Titular', precioTotal 'Precio Total', formaDePago 'Forma de pago', 
                DATE_FORMAT(fechaRegistro, '%d-%m-%Y %H:%i:%s') 'Fecha de Registro'
                from reserva r join persona p
                on r.ci=p.ci;";

            return realizarConsulta(sentencia, "Consultar todas las reserva");
        }

        public DataTable verTodasLasReservasConfirmada()
        {
            String sentencia = @"
                select id 'Id Reserva', r.ci 'Titular', p.primerNombre 'Nombre', p.primerApellido 'Apellido',inicio 'Inicio', 
                fin 'Fin', tipoDeIngreso 'Ingreso del Titular', precioTotal 'Precio Total', formaDePago 'Forma de pago', 
                DATE_FORMAT(fechaRegistro, '%d-%m-%Y %H:%i:%s') 'Fecha de Registro'
                from reserva r join persona p
                on r.ci=p.ci
                where r.estado='Confirmada';";

            return realizarConsulta(sentencia, "Consultar todas las reservas confirmada");
        }

        public DataTable verTodasLasReservasCancelada()
        {
            String sentencia = @"
                select id 'Id Reserva', r.ci 'Titular', p.primerNombre 'Nombre', p.primerApellido 'Apellido',inicio 'Inicio', 
                fin 'Fin', tipoDeIngreso 'Ingreso del Titular', precioTotal 'Precio Total', formaDePago 'Forma de pago', 
                DATE_FORMAT(fechaRegistro, '%d-%m-%Y %H:%i:%s') 'Fecha de Registro'
                from reserva r join persona p
                on r.ci=p.ci
                where estado='Cancelada';";

            return realizarConsulta(sentencia, "Consultar todas las reserva");
        }

        public DataTable verTodasLasReservasFinalizada()
        {
            String sentencia = @"
                select id 'Id Reserva', r.ci 'Titular', p.primerNombre 'Nombre', p.primerApellido 'Apellido',inicio 'Inicio', 
                fin 'Fin', tipoDeIngreso 'Ingreso del Titular', precioTotal 'Precio Total', formaDePago 'Forma de pago', 
                DATE_FORMAT(fechaRegistro, '%d-%m-%Y %H:%i:%s') 'Fecha de Registro'
                from reserva r join persona p
                on r.ci=p.ci
                where estado='Finalizada';";

            return realizarConsulta(sentencia, "Consultar todas las reserva");
        }

        public DataTable verTodasLosEmpleados()
        {
            String sentencia = @"
                SELECT p.ci 'Cédula', p.primerNombre 'Nombre', p.primerApellido 'Apellido', e.usuario 'Usuario', e.tipo 'Tipo', e.estado 'Estado'
                from empleado e join persona p
                on e.ci=p.ci;";

            return realizarConsulta(sentencia, "Consultar todas los empleados");
        }

        public DataTable verServicioDeReserva(int id)
        {
            String sentencia = String.Format(@"
                select r.id 'ID', c.nombre 'Servicio', c.inicio 'Inicio', c.fin 'Fin', c.formaDePago 'Forma de Pago', c.estado 'Estado'
                from contiene c join reserva r
                on r.id=c.id
                where r.id={0};
                ", id);

            return realizarConsulta(sentencia, "Consultar servicios reservados por una reserva");
        }

        public DataTable verCliente(String ci, String nombre)
        {
            String sentencia = String.Format(@"
                    select c.ci as Cédula, p.primerNombre as Nombre, p.primerApellido as Apellido, p.fechaNacimiento 'Fecha de Nacimiento', p.genero as Género, p.direccion as Dirección, c.estado as Estado, c.fechaRegistro as 'Fecha Registro'
                    from cliente c join persona p on c.ci = p.ci
                    where c.ci = '{0}' or p.primerNombre like '{1}';
                ", ci, nombre);

            return realizarConsulta(sentencia, "Consultar cliente por Cédula/Nombre");
        }

        public DataTable verReservaEntreFechas(DateTime inicio, DateTime fin)
        {
            String sentencia = String.Format(@"
                  SELECT id 'Id',ci 'Cédula',inicio 'Fecha de Inicio',
                  fin 'Fecha Final',tipodeingreso 'Tipo de Ingreso',
                  preciototal 'Precio Total',estado 'Estado',
                  fecharegistro 'Fecha de Registro',formadepago 'Forma de Pago'
                  FROM reserva WHERE fechaRegistro BETWEEN '{0}' AND '{1}';
                ", inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"));

            return realizarConsulta(sentencia, "Consultar reserva por fecha");
        }

        public DataTable verReservasEnElUltimoMes()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = @"
SELECT DATE(cuando) as Fecha,('Titulares') as Tipo, COUNT(cuando) as Cantidad FROM registroDeCambio
WHERE descripcion LIKE '%Alta de Reserva%' 
AND DATE(cuando) BETWEEN
date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) AND
LAST_DAY(date_add(last_day(now()),interval -1 MONTH))
GROUP BY Fecha 
UNION(
    SELECT DATE(cuando) as Fecha,('Integrantes') as Tipo, COUNT(cuando) as Cantidad 
    FROM registroDeCambio WHERE descripcion LIKE '%Alta de integrante%' AND 
    DATE(cuando) BETWEEN
    date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) AND
    LAST_DAY(date_add(last_day(now()),interval -1 MONTH)) 
    GROUP BY Fecha ORDER BY Cantidad
) ORDER BY Cantidad;";

            return realizarConsulta(sentencia, "Consultar reservas en el ultimo mes");

        }

        public DataTable verPorcentajeServicios()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = @"
  SELECT c.nombre as Nombre, COUNT(m.id) as Cantidad, CONCAT(
    ROUND(
        (COUNT(m.id) / (SELECT COUNT(m.id) 
        FROM contiene c JOIN maxpersonasreserva m
        ON m.id=c.id WHERE DATE(c.inicio) = Current_Date AND TIME(c.inicio) between '00:00:00' AND '23:59:59') *100 ),2
    ), '%'
) AS Porcentaje
FROM contiene c JOIN maxpersonasreserva m
ON m.id=c.id WHERE DATE(c.inicio) = Current_Date AND TIME(c.inicio) between '00:00:00' AND '23:59:59' GROUP BY c.nombre 
ORDER BY COUNT(m.id) desc;";

            return realizarConsulta(sentencia, "Consultar porcentaje de ocupacion de servicios");

        }

        public DataTable verFacturasUltMesServ()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = @"
                SELECT s.nombre as Nombre,COUNT(c.nombre) * s.precio as `Total Facturado` FROM contiene c 
JOIN servicio s ON c.nombre=s.nombre WHERE c.inicio and c.fin BETWEEN
date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) AND
LAST_DAY(date_add(last_day(now()),interval -1 MONTH)) GROUP BY c.nombre;";

            return realizarConsulta(sentencia, "Consultar total facturado de las Reservas del ultimo mes");

        }

        public DataTable verCantidadVecesServicio()
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = @"
              SELECT distinct s.nombre as Nombre,COUNT(c.id) as Cantidad FROM servicio s 
JOIN contiene c ON s.nombre=c.nombre where c.inicio 
BETWEEN date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) and
LAST_DAY(date_add(last_day(now()),interval -1 MONTH)) GROUP BY s.nombre
UNION (
    SELECT distinct s.nombre as Nombre,COUNT(c.id) = 0 as Cantidad FROM servicio s 
    JOIN contiene c ON s.nombre!=c.nombre where s.nombre NOT IN(
        SELECT s.nombre FROM servicio s 
        JOIN contiene c ON s.nombre=c.nombre where c.inicio 
        BETWEEN date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) and
        LAST_DAY(date_add(last_day(now()),interval -1 MONTH)) GROUP BY s.nombre
        ) and c.inicio 
    BETWEEN date_add(date_add(last_day(now()),interval 1 DAY),interval -2 MONTH) and
    LAST_DAY(date_add(last_day(now()),interval -1 MONTH)) GROUP BY s.nombre
    ) ORDER BY Cantidad desc;";

            return realizarConsulta(sentencia, "Consultar cantidad de servicios en el ultimo mes");
        }
        #endregion

    }//
}//
