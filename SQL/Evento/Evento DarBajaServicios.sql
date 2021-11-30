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
