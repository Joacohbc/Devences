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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Busqueda de Cliente: " + ci);
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Busqueda(si existe) de Cliente: " + ci);
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
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

                Persona persona = new Persona();
               
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
                conexion.CerrarConexion();
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consulta de Tipos de Ingresos");
            }
        }

        /// <summary>
        /// Busca si el Cliente tiene una Reserva con ese inicio que no este ni Eliminada ni Cancelada ni Finalizada, 1 si encuentra una, 0 si no la encuentra y -1 error
        /// </summary>
        /// <returns> 1 si encuentra una, 0 si no la encuentra y -1 error </returns>
        public int validarFechaReserva(Reserva reserva)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("select id from reserva where ci={0} and inicio='{1}' and not estado = 'Eliminada' and not estado = 'Cancelada' and not estado = 'Finalizada';"
                ,reserva.Ci, reserva.Inicio.ToString("yyyy-MM-dd"));

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand select = new MySqlCommand(sentencia, conexion.AbrirConexion());
                MySqlDataReader lector = select.ExecuteReader();

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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Consultar valides de una reserva: " + reserva.Ci + " en " + reserva.Inicio.ToString("yyyy-MM-dd"));
            }
        }

        /// <summary>
        /// Buscar si existen Reservas de un cliente con determinada fechade inicio y retorna el ID de la reserva(Retorna ID, 0 No, -1 error)
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
        /// Buscar si hay un empleado(1 Si, 0 No, -1 error)
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
                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Busqueda de Empleado: " + ci);
            }
        }

    }
}
