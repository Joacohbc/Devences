#Inserto 
insert into persona values(12345678,'Joaquin','','Genova','Guerendian','Masculino','2003-09-08','','En mi casa');
insert into persona values(87654321,'Peter','La Anguila','Rodriguez','Martinez','Masculino','1990-01-01','peter@gmail.com','En su casa');

#Usuario Gerente para pruebas
insert into empleado values (12345678, 'JoaquinG', aes_encrypt('admin','admin'), 'Gerente', true);
#Usuario Administrativo para preubas
insert into empleado values (87654321, 'PeterL', aes_encrypt('noadmin','noadmin'), 'Administrativo', true);

#Insertar parametros:
insert into parametros values('Ingreso Normal','150'), ('Ingreso de alojados','100'), ('Ingreso Jubilados/Pensionistas','80');

insert into parametros values ("Horario entrada","10:00"),("Horario salida","20:00") ;

insert into parametros values ("Horario entrada a vestuarios","10:00"), ("Horario salida de vestuarios","20:30");

#Insertar Servicios:

INSERT INTO servicio
VALUES ('Masaje tradicional','1:0',50,NULL,600);

INSERT INTO servicio
VALUES ('Masaje oriental','1:0',50,NULL,700);

INSERT INTO servicio
values ('Yoga','0:30',10,NULL,800);

INSERT INTO servicio
values ('Pilates','0:30',10,NULL,800);

INSERT INTO servicio
values ('MeditaciÃ³n','0:30',10,NULL,500);

INSERT INTO servicio
values ('Alquiler de bicicletas','0:30',1,20,100);
/* el 20 es un valor estimado inventado de la cantidad de
  bicicletas */

INSERT INTO servicio
values ('Cabalgatas','1:0',2,5,500);
/* el 5 es un numero inventado de la cant de caballos */

INSERT INTO servicio
values ('Paseos en bote','1:0',2,5,400);
/* el 5 es un numero inventado de la cant de botes */

INSERT INTO servicio
values ('Camionetas','5:50',6,2,350);

