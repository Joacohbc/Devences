SET GLOBAL event_scheduler = ON;

drop event if exists darBajaReservas;

delimiter //

CREATE EVENT darBajaReservas
ON SCHEDULE EVERY 1 MINUTE STARTS '2021-11-14 00:00:00'
DO 

BEGIN
	/*
	Si la reserva tiene su fin es mayor a la fecha actual(osea que ya termino), y esta Confirmada, que se Finalize
	*/
	update reserva set estado='Finalizada' where fin > current_date() and estado='Confirmada';


	/*
	Si la reserva tiene su inicio mayor por un dia a la fecha actual, y esta No Confirmada, que se Elimine
	*/
	update reserva set estado='Eliminada' where  datediff(fechaRegistro, current_timestamp()) > 1 and estado='No Confirmada';
END //

delimiter ;


