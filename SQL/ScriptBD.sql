SELECT * FROM proyectoprueba.reserva;

/*
Si la reserva tiene su fin menor a fecha actual, y esta Confirmada, que se Finalize
*/
update reserva set estado='Finalizada' where fin < current_timestamp() and estado='Confirmada';


/*
Si la reserva tiene su fin menor a fecha actual, y esta No Confirmada, que se Elimine
*/
update reserva set estado='Eliminada' where fin < current_timestamp() and estado='No Confirmada';

desc reserva;