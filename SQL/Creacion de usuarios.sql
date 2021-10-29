#Creo el usuario para login
create user login;
#Le asigno la contrasenia
set password for login=PASSWORD('login');
#Le doy permiso para consultar solamente en la tabla de empleados y la
#tabla persona
grant select on proyectoprueba.empleado to login;
grant select on proyectoprueba.persona to login;

#--------------------------------------------------------------------------

#Creo el usuario para el Gerente
create user gerente;
#Le asigno la contrasenia
set password for gerente=PASSWORD('gerente');

#Le asigno los privilegios

#Sobre la Tabla Persona:
/*
Insert: Dar Altas a Personas(Empleado y Clientes)
Update: Modificar y Dar Bajas a Personas(Empleado y Clientes)
Select: Consultar Personas(Empleado y Clientes)
*/
grant select,insert,update on proyectoprueba.persona to gerente;

#Sobre la Tabla Telefono
grant select,insert,update,delete on proyectoprueba.telefono to gerente;
/*
Insert: Dar Altas a Telefonos de Personas
Update: Modificar y Dar de Baja de Telefonos de Personas
Select: Consultar Telefonos de Personas
*/

#Sobre la Tabla Cliente
grant select,insert,update on proyectoprueba.cliente to gerente;
/*
Insert: Dar Altas de Clientes
Update: Modificar y Dar Baja de Clientes
Select: Consultar Clientes
*/

#Sobre la Tabla Empleado
grant select,insert,update on proyectoprueba.empleado to gerente;
/*
Insert: Dar Altas de Empleados
Update: Modificar y Dar Baja de Empleados
Select: Consultar Empleados
*/

#Sobre la Tabla RegistroDeCambio
grant select,insert on proyectoprueba.registroDeCambio to gerente;
/*
Insert: Dar Altas de Registros
Select: Consultar los Registros
*/

#Sobre la Tabla Integran
grant select,insert,update on proyectoprueba.integran to gerente;
/*
Insert: Dar Altas Acompaniantes de la Reserva
Update: Modificar el tipo de Ingreso del Acompaniante
Select: Consultar Acompaniantes
*/

#Sobre la Tabla Reserva
grant select,insert,update on proyectoprueba.reserva to gerente;
/*
Insert: Dar Altas de Reservas
Update: Modificar las Reserva y Dar Baja de Reservas
Select: Consultar Reserva
*/

#Sobre la Tabla Contiene
grant select,insert,update on proyectoprueba.contiene to gerente;
/*
Insert: Dar Altas de Servicios para una Reserva
Update: Modificar Servicios de una Reserva y Dar Baja de Servicios de Reserva
Select: Consultar Servicios de una Reserva
*/

#Sobre la Tabla Servicio
grant select,update on proyectoprueba.servicio to gerente;
/*
Update: Modificar caracteristicas de un Servicios
Select: Consultar los Servicios del SPA
*/

#Sobre la Tabla Parametros
grant select,update on proyectoprueba.parametros to gerente;
/*
Update: Modificar Precios, Horarios y cantidad de camionetas activas
Select: Consultar Precios, Horarios y cantidad de camionetas activas
*/

#--------------------------------------------------------------------------

#Creo el usuario para el Gerente
create user administrativo;
#Le asigno la contrasenia
set password for administrativo=PASSWORD('administrativo');

#Le asignos privilegios

#Sobre la Tabla Persona
grant insert, update, select on proyectoprueba.persona to administrativo;

#Sobre la Tabla Telefono
grant insert, update, select, delete  on proyectoprueba.telefono to administrativo;

#Sobre la Tabla Cliente
grant insert, update, select on proyectoprueba.cliente to administrativo;

#Sobre la Tabla Integran
grant insert, update, select on proyectoprueba.integran to administrativo;

#Sobre la Tabla Contiene
grant insert, update, select on proyectoprueba.contiene to administrativo;

#Sobre la Tabla Servicio
grant select on proyectoprueba.servicio to administrativo;

#Sobre la Tabla RegistroDeCambio
grant insert on proyectoprueba.registroDeCambio to administrativo;

#Sobre la Tabla Parametros
grant select on proyectoprueba.parametros to administrativo;