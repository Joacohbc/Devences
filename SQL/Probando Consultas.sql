/*
Esta sentencia checkea que el inicio la cantidad servicio reservados(por inicio) 
que estan dentro de un rango indicado.

Osea, es para saber cuantas reservas de un servicio hay dentro de un margen de tiempo.
Sive para saber si puedo agregar un nuevo servicio dentro de ese margen, o ya va 
estar a su maxima capacidad
*/
select count(nombre)
from contiene 
where inicio between '2021-10-17 17:14:00' and '2021-10-17 17:35' and nombre = 'Alquiler de bicicletas';

#Lo mismo que la de arriba, pero devuelve todos los datos
select *
from contiene 
where inicio between '2021-10-28 18:00:00' and '2021-10-28 18:35:00' and nombre = 'Alquiler de bicicletas';

#Cantidad de integrantes de cada reserva
select r.id, r.inicio, (r.ci), count(i.ci) as 'Cantidad de Integrantes'
from cliente c join integran i join reserva r
on c.ci = i.ci and r.id=i.id
group by r.id;

####################################
#LAS 2 SENTECIAS ANTERIORES UNIDAS##
####################################

/*
Cuantas personas hay en un servicio
en determinado periodo de tiempo

NO TIENE EN CUENTA LAS RESERVA SIN INTEGRANTES
*/
select count(i.ci)
from cliente c join integran i join reserva r
on c.ci = i.ci and r.id=i.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and i.id in 
(
select id 
from contiene 
where (inicio between '2021-10-28 18:00:00' and '2021-10-28 18:35:00') 
and nombre = 'Alquiler de bicicletas'
);
#group by r.id; Uso esto si quiero saber de que reserva son
#Sino solo quiero el restualdo final

/*
Cuantas reservas(PARA TITULARES), reservaron un servicio
en determinado periodo de tiempo
*/
select count(r.id)
from contiene c join reserva r
on c.id = r.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and r.id in 
(
select id 
from contiene 
where (inicio between '2021-10-28 18:00:00' and '2021-10-28 18:35:00') 
and nombre = 'Alquiler de bicicletas'
);
#group by i.id; Uso esto si quiero saber de que reserva son
			   #en este caso solo quiero el resultado final


######################################################
#LA SUMA DEL RESULTADO 2 SENTECIAS ANTERIORES UNIDAS##
######################################################

/*
Devuelve la suma de los integrantes y titurales de re las reservas(que esten
confirmadas) que reservaron determinado servicio en determinado periodo de tiempo
*/
//SELECT
(select count(i.ci)
from cliente c join integran i join reserva r
on c.ci = i.ci and r.id=i.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and i.id in 
(
select id 
from contiene 
where (inicio between '2021-11-07 16:10:33' and '2021-11-07 16:40:33') 
and nombre = 'Alquiler de bicicletas'))
+
(select count(r.id)
from contiene c join reserva r
on c.id = r.id
where (not r.estado = 'Eliminada' and not r.estado = 'Cancelada' and not r.estado = 'No Confirmada') and r.id in 
(
select id 
from contiene 
where (inicio between '2021-11-07 16:10:33' and '2021-11-07 16:40:33') 
and nombre = 'Alquiler de bicicletas')) 
as 'Clientes totales';


##########################################################################################################

/*
Devuelve la cantidad de reserva de un determinado cliente
donde la fecha ingresada estan dentro de inicio/fin

Osea sirve para comprobar todos los dias de una nueva reserva
que se quiera ingresar. Esto hacerlo dia por dia de esa reserva
para saber si ese dia el cliente no tiene ya una reserva hecha 
*/
select * from reserva where ('2021-10-20' between inicio and fin) and ci=12345671;
