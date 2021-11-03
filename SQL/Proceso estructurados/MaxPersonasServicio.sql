/*
Devuelve la suma de los integrantes y titurales de las reservas(que esten
confirmadas) que reservaron determinado servicio en determinado periodo de tiempo

-fechaInicio: Fecha de inicio apartir de la cual quiero buscar
servicios

-fechaFin: Fecha de final apartir de la cual dejo de buscar
servicios

-nombreServicio: Cual servicio quiero buscar
*/

USE `proyectoprueba`;
DROP procedure IF EXISTS `MaxPersonasServicio`;

DELIMITER $$
USE `proyectoprueba`$$
CREATE PROCEDURE `MaxPersonasServicio` (in fechaInicio datetime, in fechaFin datetime, in nombreServicio varchar(50))
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