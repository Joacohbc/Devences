create database if not exists proyectoprueba;
use proyectoprueba;

#Tabla Persona
create table if not exists persona (
ci int(8),
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
fechaRegistro timestamp not null,
#Predeterminadamente estara de dada del alta
estado bool not null default true,
primary key(ci),
foreign key(ci) references persona(ci));

#Tabla Empleado
create table empleado (
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
inicio date not null,
fin date not null,
tipoDeIngreso enum('Normal', 'Hospedado', 'Pensionista o Jubilado') not null,
precioTotal int(11) not null,
#Predeterminadamente estara No Confirmada
estado enum('Confirmada','No Confirmada', 'Eliminada' ,'Cancelada', 'Finalizada') default 'No Confirmada',
formaDePago enum('Credito', 'Debito', 'Contado') not null,
primary key(id),
foreign key(ci) references cliente(ci)
);

#Tabla Servicio
create table if not exists servicio (
nombre varchar(50) not null,
duracion time not null,
capacidadMax int(3) not null,
precio int(11) not null,
primary key(nombre));

#Tabla RegistroDeCambio
create table if not exists registroDeCambio (
id int(11) auto_increment not null,
ci int(8) not null,
primary key(id),
foreign key(ci) references empleado(ci));

#Tabla de la Relacion Integran
create table if not exists integran (
id int(11) not null,
ci int(8) not null,
tipoDeIngreso enum('Normal', 'Hospedado', 'Pensionista o Jubilado') not null,
primary key(id));

#Tabla de la Relacion Contiene
create table if not exists contiene (
id int(11) not null,
nombre varchar(50) not null,
inicio date not null, 
fin date not null,
estado enum('Confirmada','No Confirmada','Finalizada') default 'Confirmada',
formaDePago enum('Credito', 'Debito', 'Contado') not null,
primary key(id,nombre));

#Tabla Parametros
create table if not exists parametros (
titulo varchar(50) not null,
valor varchar(50) not null,
primary key(titulo,valor));
