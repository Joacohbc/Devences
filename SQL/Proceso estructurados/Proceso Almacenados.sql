DELIMITER $$
CREATE PROCEDURE `comprobarDiaEnReserva`(in dia date, in cliente int)
BEGIN
select id from reserva where (dia between inicio and fin) and ci=cliente and estado not in ('Eliminada', 'Finalizada', 'Cancelada');
END$$
DELIMITER ;


