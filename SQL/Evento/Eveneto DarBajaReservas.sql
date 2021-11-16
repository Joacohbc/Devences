SET GLOBAL event_scheduler = ON;

drop event if exists darBajaReservas;

delimiter //

CREATE EVENT darBajaReservas
ON SCHEDULE EVERY 24 HOUR STARTS '2021-11-14 00:00:00'
DO 

BEGIN
	/*
	Si la reserva tiene su fin menor a fecha actual, y esta Confirmada, que se Finalize
	*/
	update reserva set estado='Finalizada' where fin < current_timestamp() and estado='Confirmada';


	/*
	Si la reserva tiene su inicio mayor a fecha actual(osea que ya empezo), y esta No Confirmada, que se Elimine
	*/
	update reserva set estado='Eliminada' where inicio > current_timestamp() and estado='No Confirmada';
END //

delimiter ;


