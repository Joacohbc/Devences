create database if not exists proyectoprueba;
use proyectoprueba;

#Tabla Persona
create table if not exists persona (
ci int(8) not null,
primerNombre varchar(20) not null,
segundoNombre varchar(20) default null,
primerApellido varchar(20) not null,
segundoApellido varchar(20) not null,
genero enum('Masculino','Femenino','No Binario') not null,
fechaNacimiento date not null,
mail varchar(320) default null,
direccion varchar(250) not null,
primary key(ci));

#Tabla Telefonos de personas
create table if not exists telefono (
ci int(8) not null,
telefono varchar(21) not null,
primary key(ci, telefono),
foreign key(ci) references persona(ci));

#Tabla Cliente
create table if not exists cliente (
ci int(8) not null,
fechaRegistro timestamp default current_timestamp(),
#Predeterminadamente estara de dada del alta
estado bool default true,
primary key(ci),
foreign key(ci) references persona(ci));

#Tabla Empleado
create table if not exists empleado (
ci int(8) not null,
usuario varchar(20) not null unique, 
contra varbinary(256) not null,
tipo enum('Gerente','Administrativo') not null,
#Predeterminadamente estara de dada del alta
estado bool default true,
primary key(ci),
foreign key(ci) references persona(ci)
);

#Tabla Reserva
create table if not exists reserva (
id int(11) auto_increment not null, 
ci int(8) not null,
inicio date not null,#Date y no DateTime porque es por todo el dia
fin date not null,#Date y no DateTime porque es por todo el dia
tipoDeIngreso enum('Ingreso Normal', 'Ingreso de alojados', 'Ingreso Jubilados/Pensionistas') not null,
precioTotal int(11) not null,
#Predeterminadamente estara No Confirmada
estado enum('Confirmada','No Confirmada', 'Eliminada' ,'Cancelada', 'Finalizada') default 'No Confirmada',
fechaRegistro timestamp default current_timestamp(),
formaDePago enum('Credito', 'Debito', 'Contado') not null,
primary key(id, ci, inicio, estado),
foreign key(ci) references cliente(ci)
);

#Tabla Servicio
create table if not exists servicio (
nombre varchar(50) not null,
duracion time not null,
capacidadMax int(3) not null,

#Atributo para poder guardar la cantidad de Camionetas, Bicis, Caballos u otra
#cantidad en caso de que el servicio la necesite
cantidad int(3) default null,
precio int(11) not null,
primary key(nombre));

#Tabla RegistroDeCambio
create table if not exists registroDeCambio (
id int(11) auto_increment not null,
ci int(8) not null,
sentencia varchar(1000) not null,
descripcion varchar(100) not null,
cuando timestamp default current_timestamp(),
primary key(id),
foreign key(ci) references empleado(ci));

#Tabla de la Relacion Integran
create table if not exists integran (
id int(11) not null,
ci int(8) not null,
tipoDeIngreso enum('Ingreso Normal', 'Ingreso de alojados', 'Ingreso Jubilados/Pensionistas') not null,
primary key(id, ci),
foreign key(id) references reserva(id),
foreign key(ci) references cliente(ci));

#Tabla de la Relacion Contiene
create table if not exists contiene (
id int(11) not null,
nombre varchar(50) not null,
inicio datetime not null,#Datetime porque se necesita saber el dia y fecha que se registro
fin datetime not null,#Datetime porque se necesita saber el dia y fecha que se registro
estado enum('Confirmada','Cancelada','Finalizada') default 'Confirmada',
formaDePago enum('Credito', 'Debito', 'Contado') not null,
primary key(id,nombre,inicio),
foreign key(id) references reserva(id),
foreign key(nombre) references servicio(nombre));

#Tabla Parametros
create table if not exists parametros (
titulo varchar(50) not null,
valor varchar(50) not null,
primary key(titulo,valor));

############################################################################################################################

drop procedure `comprobarDiaEnReserva`;

DELIMITER $$
CREATE PROCEDURE `comprobarDiaEnReserva`(in dia date, in cliente int)
BEGIN
select id from reserva where (dia between inicio and fin) and ci=cliente and estado not in ('Eliminada', 'Finalizada', 'Cancelada');
END$$
DELIMITER ;

drop procedure `MaxPersonasServicio`;

DELIMITER $$
CREATE PROCEDURE `MaxPersonasServicio`(in fechaInicio datetime, in fechaFin datetime, in nombreServicio varchar(50))
BEGIN
SELECT
(select count(i.ci)
from cliente c join integran i join reserva r
on c.ci = i.ci and r.id=i.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and i.id in 
(
select id 
from contiene 
where (inicio between fechaInicio and fechaFin) 
and nombre = nombreServicio))
+
(select count(r.id)
from contiene c join reserva r
on c.id = r.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and r.id in 
(
select id 
from contiene 
where (inicio between fechaInicio and fechaFin) 
and nombre = nombreServicio))
as 'Clientes totales';
END$$
DELIMITER ;

##############################################################################################################################

#Inserto 2 Personas
insert into persona values(53626663,'Joaquin','','Genova','Guerendian','Masculino','2003-09-08','','Av Italia');
insert into persona values(53588134,'Peter','Gonzales','Rodriguez','Martinez','Masculino','1990-01-01','peter@gmail.com','8 de Octubre');

#Usuario Gerente para pruebas
insert into empleado values (53626663, 'JoaquinG', aes_encrypt('admin','admin'), 'Gerente', true);

#Usuario Administrativo para preubas
insert into empleado values (53588134, 'PeterG', aes_encrypt('noadmin','noadmin'), 'Administrativo', true);

#Insertar parametros:
insert into parametros values('Ingreso Normal','150'), ('Ingreso de alojados','100'), ('Ingreso Jubilados/Pensionistas','80');

insert into parametros values ("Horario entrada","10:00"),("Horario salida","20:00") ;

insert into parametros values ("Horario entrada a vestuarios","10:00"), ("Horario salida de vestuarios","20:30");

#Insertar Servicios:

INSERT INTO servicio
VALUES ('Masaje tradicional','01:00',50,0,600);

INSERT INTO servicio
VALUES ('Masaje oriental','01:00',50,0,700);

INSERT INTO servicio
values ('Yoga','00:30',10,0,800);

INSERT INTO servicio
values ('Pilates','00:30',10,0,800);

INSERT INTO servicio
values ('Meditacion','00:30',10,0,500);

INSERT INTO servicio
values ('Alquiler de bicicletas','0:30',1,20,100);
/* el 20 es un valor estimado inventado de la cantidad de
  bicicletas */

INSERT INTO servicio
values ('Cabalgatas','01:00',2,5,500);
/* el 5 es un numero inventado de la cant de caballos */

INSERT INTO servicio
values ('Paseos en bote','01:00',2,5,400);
/* el 5 es un numero inventado de la cant de botes */

INSERT INTO servicio
values ('Camionetas','05:50',6,2,350);

INSERT INTO servicio 
values ('Piscina de agua tibia abierta','02:00:00',50,0,0);

INSERT INTO servicio
values ('Piscina de agua tibia cerrada','02:00:00',50,0,0);

INSERT INTO servicio
values ('Piscina de barro','00:20:00',40,0,0);

##########################################################################################################################3

SET GLOBAL event_scheduler = ON;

drop event if exists darBajaServicios;

delimiter //

CREATE EVENT darBajaServicios
ON SCHEDULE EVERY 1 MINUTE STARTS '2021-11-14 00:00:00'
DO 

BEGIN
	/*
	Si el servicio tiene su fin menor a fecha actual, y esta Confirmada, que se Finalize
	*/
	update contiene set estado='Finalizada' where fin < current_timestamp() and estado='Confirmada';

END //

delimiter ;


drop event if exists darBajaReservas;

delimiter //

CREATE EVENT darBajaReservas
ON SCHEDULE EVERY 1 MINUTE STARTS '2021-11-14 00:00:00'
DO 

BEGIN
	/*
		Si el perido de una reserva confirmada vencio, es decir, la fecha de fin es anterior a la actual
        esta sera finalizada
	*/
	update reserva set estado='Finalizada' 
	where fin < current_date() and estado='Confirmada';


	/*
		Si la reserva esta No Confirmada y su fecha de registro pasa las 24hs sin confirmacio la reserva es eliminada
	*/
	update reserva set estado='Eliminada' 
    where timestampdiff(HOUR, fechaRegistro, now()) >= 24 and estado='No Confirmada';
END //

delimiter ;

#################################################################################################################################

