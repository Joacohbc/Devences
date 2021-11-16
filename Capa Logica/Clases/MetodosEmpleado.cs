using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_de_Datos.Login;
using Capa_Entidades;

namespace Capa_Logica.Clases
{
    public class MetodosEmpleado
    {
        #region Login

        /// <summary>
        /// Verifica si existe un usuario y retornar su rol 0-Administrativo y 1-Gerente
        /// </summary>
        /// <param name="usuario"> El nombre del usuario</param>
        /// <param name="contra"> La contrasenia del usuario</param>
        /// <returns> Retorna el tipo de rol que tiene el usuario,(-1 o -2 son errores)</returns>
        public static int Loguearse(TextBox txtUsuario, TextBox txtContra)
        {
            //Valida el campo de usuario
            if (validarUsuarioYContra(txtUsuario, 0))
            {
                //Valida el campo de contrasenia
                if (validarUsuarioYContra(txtContra, 1))
                {
                    //Retorna el tipo de rol
                    return Login.Loguearse(txtUsuario.Text, txtContra.Text);
                }
                else
                {
                    //Retonar otro numero, da igual, ya que el mensaje de error
                    //Lo muestra este metodo
                    return -3;
                }
            }
            else
            {
                //Retonar otro numero, da igual, ya que el mensaje de error
                //Lo muestra este metodo
                return -3;
            }
        }

        /// <summary>
        /// Este metodo se le pide el usuario y retorna un objeto Empleado con todos los datos(menos las contrasenia), en caso
        /// de errror retorna null
        /// </summary>
        /// <param name="usuario"> El usuario del Empleado que se quiere</param>
        /// <returns> El Objeto empleado cargado o Null si hay un error</returns>
        public static Empleado BuscarUsuario(String usuario)
        {
            return Login.BuscarEmpleado(usuario);
        }

        /// <summary>
        /// Valida que un usuario sea valido
        /// </summary>
        /// <param name="txtBox"> El campo que quiere validar</param>
        /// <param name="deQue"> Si es 0, muestra un mensaje de error para el usuario y su es diferente de 0 muestra
        /// un mensaje de error para la contraseña</param>
        private static bool validarUsuarioYContra(TextBox txtBox, int deQue)
        {
            Validaciones validar = new Validaciones();
            int validacion = validar.validarLetrasDigitos(txtBox.Text.ToLower(), 20, false, "");
            if (validacion == 0)
            {
                return true;
            }
            else if (validacion == -1)
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario no puede estar vacio", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña no puede estar vacio", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
            else if (validacion == -2)
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario debe tener menos de 20 caracteres", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña debe tener menos de 20 caracteres", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
            else
            {
                if (deQue == 0)
                    Mensaje.MostrarError("El campo del usuario solo puede contener digitos y letras(Sin espacios)", Mensaje.ErrorIngreso);
                else
                    Mensaje.MostrarError("El campo del a contraseña solo puede contener digitos y letras(Sin espacios)", Mensaje.ErrorIngreso);

                txtBox.Focus();
                return false;
            }
        }
        #endregion

        //LOS METODOS DE LOGUEO SON ESTATICOS
        //YA QUE NO NECESITAN NI LA CEDULA NI EL ROL
        //PERO EL RESTO NO LO SON PORQUE SE NECESITA 
        //Y PARA ESO ESTA EL COSNTRUCTOR DE LA CLASE QUE LOS PIDE

        private int ci;
        private int rol;
        private Altas altas;
        private Consultas consultas;
        private Modificaciones modificaciones;

        public MetodosEmpleado(int ci, int rol)
        {
            this.ci = ci;
            this.rol = rol;
            altas = new Altas(rol, ci);
            consultas = new Consultas(rol, ci);
            modificaciones = new Modificaciones(rol, ci);
        }


        /// <summary>
        /// Pide la cedula y busca a la Cliente(Si esta dado de Alta), Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int buscarCliente(int ci) => consultas.buscarCliente(ci);

        /// <summary>
        /// Pide la cedula y busca a la Cliente(Si existe), Retorna 1 si ya existe, 0 si no existe y -1 error
        /// </summary>
        public int existeCliente(int ci) => consultas.existeCliente(ci);

        /// <summary>
        /// Retorna una persona por su Cedula, si retorna null ocurrio un error o no la encontro
        /// </summary>
        public Persona traerPersona(int ci) => consultas.traerPersona(ci);

        /// <summary>
        /// Da de alta una Persona
        /// </summary>
        /// <param name="persona"> Un Objeto Persona</param>
        /// <returns> Retorna 1 si la da de Alta, retona 0 si esa persona ya existe en esa tabla y -1 si ocurrio un error</returns>
        public int darAltaPersona(Persona persona)
        {
            //Busco la persona
            int retorno = consultas.buscarPersona(persona.Ci);
            if (retorno == 0)
            {
                //Lo intento dar de alta a la Persona
                retorno = altas.altaPersona(persona);
                if (retorno > 0)
                {
                    return 1;
                }
                else
                {
                    //Si ocurrio un error a dar de alta a la persona
                    return -1;
                }
            }
            else if (retorno == 1)
            {
                //Si la persona ya existe
                return 0;
            }
            else
            {
                //Si ocurrio un error al buscar a la persona
                return -1;
            }
        }

        /// <summary>
        /// Da de alta los Telefonos(Retorna True bien, Fasle mal)
        /// </summary>
        /// <param name="persona"> El objeto Persona</param>
        /// <returns> Retorna true de si exitosa y retonar false si ocurrio un error</returns>
        public bool darAltaTelefonos(Persona persona)
        {
            //Si la Persona tiene telefono, que los registre
            if (persona.Telefonos.Count > 0)
            {
                //Recorro los telefono
                foreach (String telefono in persona.Telefonos)
                {
                    //Si ocurre un error, que retorne -1
                    if (altas.altaTelefono(persona.Ci, telefono) == -1)
                    {
                        return false;
                    }
                }
            }

            //Si llego aqui es que no hubo telefonos
            //O que todos se dieron de altas correctamente
            return true;
        }

        public int buscarIdDeReservaConfirmada(int ci, DateTime inicio) => consultas.buscarIdDeReservaConfirmada(ci, inicio);

        public Reserva traerReserva(int ci, DateTime inicio) => consultas.traerReserva(ci, inicio);

        public Empleado traerEmpleado(int ci) => consultas.traerEmpleado(ci);

        #region Metodos Altas Clientes
        /// <summary>
        /// Valida un cliente
        /// </summary>
        /// <param> PIde los datos de Cliente</param>
        /// <returns> El Objeto Cliente cargado si es valido sino retorna null</returns>
        public Cliente validarCliente(TextBox txtCedula, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido,
           TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos, ErrorProvider errorProvider)
        {
            //Valida la cedula
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                //Valido Primer nombre
                if (ValidarPersona.ValidarPrimerNombre(txtPrimerNombre, errorProvider))
                {
                    //Valido segundo nombre
                    if (ValidarPersona.ValidarSegundoNombre(txtSegundoNombre, errorProvider))
                    {
                        //Valido primer apellido
                        if (ValidarPersona.ValidarApellido(txtPrimerApellido, 1, errorProvider))
                        {
                            //Valido segundo apellido(Opcional)
                            if (ValidarPersona.ValidarApellido(txtSegundoApellido, 2, errorProvider))
                            {
                                //Valido mail(Opcional)
                                if (ValidarPersona.ValidarMail(txtMail, errorProvider))
                                {
                                    //Valido direccion
                                    if (ValidarPersona.ValidarDireccion(txtDireccion, errorProvider))
                                    {
                                        //Valido fecha de nacimiento
                                        if (ValidarPersona.ValidarFechaNacimiento(dtpNacimiento, errorProvider))
                                        {

                                            return CreacionObjeto.CrearCliente(Convert.ToInt32(txtCedula.Text), txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos);

                                        }
                                        else
                                        {
                                            return null;
                                        }
                                    }
                                    else
                                    {
                                        return null;
                                    }
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Da de alta un Cliente
        /// </summary>
        /// <param name="cliente"> Un Objeto Cliente</param>
        /// <returns> Retorna 1 si la da de Alta, retona 0 si esa persona ya existe en esa tabla y -1 si ocurrio un error</returns>
        public int darAltaCliente(Cliente cliente)
        {
            //Busco la persona
            int retorno = consultas.buscarCliente(cliente.Ci);
            if (retorno == 0)
            {
                //Lo intento dar de alta a la Cliente
                retorno = altas.altaCliente(cliente);
                if (retorno > 0)
                {
                    return 1;
                }
                else
                {
                    //Si ocurrio un error a dar de alta a la Cliente
                    return -1;
                }
            }
            else if (retorno == 1)
            {
                //Si la Cliente ya existe
                return 0;
            }
            else
            {
                //Si ocurrio un error al buscar a la Cliente
                return -1;
            }
        }

        #endregion

        #region Metodos Alta Reserva
        /// <summary>
        /// Retorna una Lista con Nombre y precio
        /// </summary>
        /// <returns> Retona la lista </returns>
        public List<String> traerTipoIngreso()
        {
            //Tipos de Ingresos traidos de la BD
            List<String[]> tiposDeIngresosTraidosDB = consultas.traerTiposDeIngreso();

            //Creo la nueva List que voy a retornar
            List<String> tiposDeIngresosRetonar = new List<string>();


            //Recorro lo que traje de la base de datos(Contiene un Array donde en [0] guardo el nombre y en [1] guardo el precio
            foreach (String[] tipoDeIngreso in tiposDeIngresosTraidosDB)
            {
                //Agrego el TipoDeIngreso + ($ + precio + ) en la List que voy a retornar
                tiposDeIngresosRetonar.Add(tipoDeIngreso[0] + "($" + tipoDeIngreso[1] + ")");
            }

            //Luego retorno
            return tiposDeIngresosRetonar;
        }

        /// <summary>
        /// Valida que una reserva sea valida, si no retorna un Array Objet donde el Index 1 es Null(error en cedula), -1(Si el Titular es un Integrante), -2(titular no existe), -3(error al buscar titular),-4(error en fechas)
        /// </summary>
        public Object[] validarReserva(TextBox txtCiTitular, ErrorProvider errorProvider, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFin,
            ComboBox cmbTipoDeIngreso, ComboBox cmbFormaDePago, CheckBox chkConfirmada, List<Integrantes> integrantes)
        {
            if (ValidarPersona.ValidarCedula(txtCiTitular, errorProvider))
            {
                Validaciones validaciones = new Validaciones();
                if (validaciones.validarFechaPrimeraEsMenor(dtpFechaInicio.Value, dtpFechaFin.Value))
                {

                    int existe = consultas.buscarCliente(Convert.ToInt32(txtCiTitular.Text));

                    if (existe == 1)
                    {
                        bool titularRepetetido = false;
                        //Recorro los integrantes
                        foreach (Integrantes i in integrantes)
                        {
                            //Si alguna cedula del Integrante es igual a la del Titular
                            if (i.Ci == Convert.ToInt32(txtCiTitular.Text))
                            {
                                //Sigmifica que el Titular esta como Integrante
                                titularRepetetido = true;
                                break;
                            }
                        }

                        //Si el titular no esta como integrante
                        if (!titularRepetetido)
                        {
                            Object[] retornar = {CreacionObjeto.CrearReserva(consultas.traerTiposDeIngreso(), Convert.ToInt32(txtCiTitular.Text), dtpFechaInicio,
                            dtpFechaFin, cmbTipoDeIngreso, cmbFormaDePago, chkConfirmada), 1};
                            return retornar;
                        }
                        else
                        {
                            //Si la Ci del Titular esta como cliente retorna -1
                            Object[] retornar = { null, -1 };
                            return retornar;
                        }

                    }
                    else if (existe == 0)
                    {
                        //Si el Titular no existe como cliente retorna -2
                        Object[] retornar = { null, -2 };
                        return retornar;
                    }
                    else
                    {
                        //Si ocurrio un error al buscar el Titular retorna -3
                        Object[] retornar = { null, -3 };
                        return retornar;
                    }
                }
                else
                {
                    //Si las fechas son invalidas retorna -2
                    Object[] retornar = { null, -4 };
                    return retornar;
                }
            }
            else
            {
                //Si la cedula del titular es Invalida, El metodo ValidarCedula ya muestrar el ErrorProvider
                Object[] retornar = { null, -5 };
                return retornar;
            }
        }

        /// <summary>
        /// Busca si el Cliente tiene una Reserva con ese inicio que no este ni Eliminada ni Cancelada ni Finalizada, 1 si encuentra una, 0 si no la encuentra y -1 error
        /// </summary>
        /// <returns> 1 si encuentra una, 0 si no la encuentra y -1 error </returns>
        public int buscarIdReserva(Reserva reserva) => consultas.buscarIdDeReserva(reserva.Ci, reserva.Inicio);

        /// <summary>
        /// Da de alta una reserva y sus Integrantes, retona 1 si fue exitosa y -1 si no
        /// </summary>
        public int altaReserva(Reserva reserva, List<Integrantes> integrantes)
        {

            //Si la reserva tiene integrantes
            if (integrantes.Count > 0)
            {
                List<String[]> tiposDeIngresosTraidosDB = consultas.traerTiposDeIngreso();

                //Recorro todos los integrantes
                foreach (Integrantes i in integrantes)
                {
                    //Busco su tipo de ingreso
                    foreach (String[] tipoDeIngreso in tiposDeIngresosTraidosDB)
                    {
                        //Donde el tipo de ingreso sea igual al del integrante que le sume el precio del tipo de ingreso al total
                        if (i.TipoDeIngreso == tipoDeIngreso[0])
                        {
                            reserva.PrecioTotal += Convert.ToInt32(tipoDeIngreso[1]);
                            break;
                        }
                    }
                }
            }

            //Calculo el Precio total en el Suma de los Ingreso X Cantidad de dias

            int diasReservados = (reserva.Fin - reserva.Inicio).Days;
            /*
             El metodos .Days devuevle la cantidad de dias entre 2 fechas, si hay 0 dias
             sigmifica que reservo solo un dia. Osea dejamos el PrecioTotal tal como esta

            Pero si deuvelve != a 0 hay que sumarle 2, el dia de inico y el dia de Fin
             */

            if (diasReservados != 0)
            {
                reserva.PrecioTotal = reserva.PrecioTotal * ((reserva.Fin - reserva.Inicio).Days + 2);
            }

            return altas.altaReserva(reserva, integrantes);
        }

        public Object[] comprobarDiasTodosDiasReservas(int ci, DateTime inicio, DateTime final)
        {
            //Recorro todos los dias de la reserva(contado Inicio y Fin) 
            //y compruebo que ya no esten reservados en una reserva
            for (DateTime dia = inicio; dia <= final; dia = dia.AddDays(1))
            {
                //Comprobar si ese dia ya esta registrado
                int valido = consultas.comprobarDiaEnReserva(ci, dia);
                if (valido == 1)
                {
                    //Si ya esta registrado
                    Object[] yaExiste = {dia, 1};
                    return yaExiste;
                }
                else if (valido == -1)
                {
                    //Si ocurrio un error
                    Object[] error = { null, -1};
                    return error;
                }
            }

            /*
             Si recorre todo todos los dias sin que existan sigmifica que todos
             los dias son validos
             */
            Object[] retorno = { null, 0};
            return retorno;
        }
        #endregion

        #region Metodos Alta Servicio

        /// <summary>
        /// Trae los servicios en una Lista<Nombre y Precio>
        /// </summary>
        public List<Servicios> traerServicios() => consultas.traerServicios();

        /// <summary>
        /// Dar de alta una servicio
        /// </summary>
        public int altaServicio(int ci, Servicios servicio, DateTime inicio, DateTime inicioServicio, String formaDePago)
        {
            //Alta de servicio solo en reservas que esten confirmadas
            int id = consultas.buscarIdDeReservaConfirmada(ci, inicio);
            if (id >= 1)
            {
                DateTime fin = inicioServicio + servicio.Duracion;
                return altas.altaServicio(id, servicio.Nombre, inicioServicio, fin, formaDePago);
            }
            else if (id == 0)
            {
                //Si no existe una Reserva Confirmada con ese cliente con ese inicio
                return -1;
            }
            else
            {
                //Si ocurre un error al busar el ID
                return -2;
            }
        }

        public int cantidadDePersonasPorServicio(DateTime fechaInicio, DateTime fechaFin, String nombre) => consultas.cantidadDePersonasPorServicio(fechaInicio, fechaFin, nombre);

        public int validarMaxCantidadServicio(Servicios servicio, DateTime fechaInicio)
        {
            //Calculo la fecha fin del servicio
            DateTime fin = (fechaInicio + servicio.Duracion);

            //Si el servicio tiene cantidad, como Biciletas, Cabalgata o Paseos en bote
            int capMax = 0;
            if (servicio.Cantidad != 0)
            {
                //MUltiplico la cantidad x la capacidadMax para obtener la capacidad maxima total
                capMax = servicio.CapacidadMaxima * servicio.Cantidad;
            }

            int retorno = cantidadDePersonasPorServicio(fechaInicio, fin, servicio.Nombre);

            if (retorno >= 0)
            {
                if (retorno <= capMax)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                //Ocurrio un error en la BD
                return -1;
            }
        }

        public int validarFechaServicio(Reserva reserva, DateTime inicioServicio)
        {
            if (reserva == null)
            {
                //Ocurrio un error
                return -1;
            }
            else if (reserva.Ci == -1)
            {
                //El cliente no tien una reserva ese dia
                return 0;
            }
            else
            {
                Validaciones validar = new Validaciones();
                if (validar.validarFechaIntermedia(inicioServicio, reserva.Inicio, reserva.Fin))
                {
                    return 1;
                }
                else
                {
                    return -2;
                }
            }

        }

        public int servicioYaExiste(String nombre, int ci) => consultas.servicioYaExiste(nombre, ci);
        #endregion

        #region Metodos Alta Empleado

        /// <summary>
        /// Valida si los atributos son validos y retorna el Objeto EMpleado(Null=Error)
        /// </summary>
        public Empleado validarEmpleado(TextBox txtCedula, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido,
            TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos, TextBox txtUsuario, ComboBox cmbTipo, TextBox txtContra, TextBox txtContra2, ErrorProvider errorProvider)
        {
            //Valida la cedula
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                //Valido Primer nombre
                if (ValidarPersona.ValidarPrimerNombre(txtPrimerNombre, errorProvider))
                {
                    //Valido segundo nombre
                    if (ValidarPersona.ValidarSegundoNombre(txtSegundoNombre, errorProvider))
                    {
                        //Valido primer apellido
                        if (ValidarPersona.ValidarApellido(txtPrimerApellido, 1, errorProvider))
                        {
                            //Valido segundo apellido(Opcional)
                            if (ValidarPersona.ValidarApellido(txtSegundoApellido, 2, errorProvider))
                            {
                                //Valido mail(Opcional)
                                if (ValidarPersona.ValidarMail(txtMail, errorProvider))
                                {
                                    //Valido direccion
                                    if (ValidarPersona.ValidarDireccion(txtDireccion, errorProvider))
                                    {
                                        //Valido fecha de nacimiento
                                        if (ValidarPersona.ValidarFechaNacimiento(dtpNacimiento, errorProvider))
                                        {
                                            if (validarUsuarioYContra(txtUsuario, 0))
                                            {
                                                if (validarUsuarioYContra(txtContra, 1))
                                                {
                                                    if (validarUsuarioYContra(txtContra2, 1))
                                                    {
                                                        if (txtContra.Text == txtContra2.Text)
                                                        {
                                                            return CreacionObjeto.CrearEmpleado(Convert.ToInt32(txtCedula.Text), txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido,
                                                                txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos, txtUsuario, cmbTipo, txtContra);
                                                        }
                                                        else
                                                        {
                                                            Mensaje.MostrarError("Las confirmacion de la contraseña con concide", Mensaje.ErrorIngreso);
                                                            return null;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        return null;
                                                    }
                                                }
                                                else
                                                {
                                                    return null;
                                                }
                                            }
                                            else
                                            {
                                                return null;
                                            }
                                        }
                                        else
                                        {
                                            return null;
                                        }
                                    }
                                    else
                                    {
                                        return null;
                                    }
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Buscar si hay un empleado de alta (1 Si, 0 No, -1 error)
        /// </summary>
        public int buscarEmpleado(int ci) => consultas.buscarEmpleado(ci);

        /// <summary>
        /// Buscar si hay un empleado de alta (1 Si, 0 No, -1 error)
        /// </summary>
        public int existeEmpleado(int ci) => consultas.existeEmpleado(ci);

        /// <summary>
        /// Da de alta un Servicio a una Reserva(1 Exito, -1 error)
        /// </summary>
        public int altaEmpleado(Empleado empleado) => altas.altaEmpleado(empleado);
        #endregion

        #region Metodos De Moficacion de Persona
        public int modificarPersona(Persona persona) => modificaciones.ModificarPersona(persona);

        public int modificarTelefonosPersona(int ci, List<String> telefonosNuevos) => modificaciones.ModificarTelefonos(ci, telefonosNuevos);
        #endregion

        #region Metodos De Moficacion de Empleado
        public int modificarEmpleado(Empleado empleado) => modificaciones.modificarEmpleado(empleado);
        

        #endregion
    }
}
