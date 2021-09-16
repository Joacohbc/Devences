#Inserto 
insert into persona values(12345678,'Joaquin','','Genova','Guerendian','Masculino','2003-09-08','','En mi casa');
insert into persona values(87654321,'Peter','La Anguila','Rodriguez','Martinez','Masculino','1990-01-01','peter@gmail.com','En su casa');

#Usuario Gerente para pruebas
insert into empleado values (12345678, 'JoaquinG', aes_encrypt('admin','admin'), 'Gerente', true);
#Usuario Administrativo para preubas
insert into empleado values (87654321, 'PeterL', aes_encrypt('noadmin','noadmin'), 'Administrativo', true);


