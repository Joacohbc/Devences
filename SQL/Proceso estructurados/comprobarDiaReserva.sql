/*
Devuelve la cantidad de reserva de un determinado cliente
donde la fecha ingresada estan dentro de inicio/fin

Osea sirve para comprobar todos los dias de una nueva reserva
que se quiera ingresar. Esto hacerlo dia por dia de esa reserva
para saber si ese dia el cliente no tiene ya una reserva hecha 
*/
USE `proyectoprueba`;
DROP procedure IF EXISTS `comprobarDiaEnReserva`;

DELIMITER $$
USE `proyectoprueba`$$
CREATE PROCEDURE `comprobarDiaEnReserva` (in dia date, in cliente int)
BEGIN
select count(id) from reserva where (dia between inicio and fin) and ci=cliente;
END$$

DELIMITER ;

call proyectoprueba.comprobarDiaEnReserva('2021-10-28', '12345671');