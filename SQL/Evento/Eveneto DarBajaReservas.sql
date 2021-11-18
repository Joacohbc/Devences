SET GLOBAL event_scheduler = ON;

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
	update reserva set estado='Finalizada' where fin < current_date() and estado='Confirmada';


	/*
		Si la reserva esta No Confirmada y su fecha de registro pasa las 24hs sin confirmacio la reserva es eliminada
	*/
	update reserva set estado='Eliminada' where  timestampdiff(HOUR, fechaRegistro, current_timestamp()) >= 24 and estado='No Confirmada';
END //

delimiter ;


