#Creo el usuario para login
create user login;
#Le asigno la contrasenia
set password for login=PASSWORD('login');
#Le doy permiso para consultar solamente en la tabla de empleados
grant select on proyectoprueba.empleado to login;

#--------------------------------------------------------------------------

#Creo el usuario para el Gerente
create user gerente;
#Le asigno la contrasenia
set password for gerente=PASSWORD('gerente');

#Le asigno los privilegios

#Sobre la Tabla Persona
grant select,insert,update on proyectoprueba.persona to gerente;

#Sobre la Tabla Telefono
grant select,insert,update on proyectoprueba.telefono to gerente;

#Sobre la Tabla Cliente 
grant select,insert,update on proyectoprueba.cliente to gerente;

#Sobre la Tabla Empleado
grant select,insert,update on proyectoprueba.empleado to gerente;

#Sobre la Tabla RegistroDeCamio 
grant select,insert on proyectoprueba.registrodecambio to gerente;

#Sobre la Tabla Integran
grant select,insert,update on proyectoprueba.integran to gerente;

#Sobre la Tabla Reserva
grant select,insert,update on proyectoprueba.reserva to gerente;

#Sobre la Tabla Contiene
grant select,insert,update on proyectoprueba.contiene to gerente;

#Sobre la Tabla Servicio
grant select,insert,update on proyectoprueba.servicio to gerente;

#Sobre la Tabla Parametros
grant select,insert,update on proyectoprueba.parametros to gerente;

#--------------------------------------------------------------------------

#Creo el usuario para el Gerente
create user administrativo;
#Le asigno la contrasenia
set password for administrativo=PASSWORD('administrativo');

#Le asignos privilegios

#Sobre la Tabla Persona
grant insert, update, select on proyectoprueba.persona to administrativo;

#Sobre la Tabla Cliente
grant insert, update, select on proyectoprueba.cliente to administrativo;

#Sobre la Tabla Integran
grant insert, update, select on proyectoprueba.integran to administrativo;

#Sobre la Tabla Contiene
grant insert, update, select on proyectoprueba.contiene to administrativo;

#Sobre la Tabla Servicio
grant select on proyectoprueba.servicio to administrativo;

#Sobre la Tabla RegistroDeCambio
grant insert on proyectoprueba.registrodecambio to administrativo;

#Sobre la Tabla Telefono
grant insert, update, select on proyectoprueba.telefono to administrativo;





