


create table loginTable(

	Object_id int NOT NULL IDENTITY(1,1) primary key,
	username varchar(150) not null,
	pass varchar(150) not null,
)

INSERT INTO loginTable(username,pass) VALUES('admin.jeyason.jeyapa','Mdsuim@2');

INSERT INTO loginTable(username,pass) VALUES('lol','hehe');

INSERT INTO loginTable(username,pass) VALUES('naruto','sasuke');

INSERT INTO loginTable(username,pass) VALUES('luffy','zoro');

INSERT INTO loginTable(username,pass) VALUES('kanye','west');

INSERT INTO loginTable(username,pass) VALUES('jeyason','jeyaparan');

INSERT INTO loginTable(username,pass) VALUES('jeyani','jeyaparan');

select * from loginTable