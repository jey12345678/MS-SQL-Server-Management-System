
IF OBJECT_ID('loginTable') IS NOT NULL
DROP TABLE loginTable;

create table loginTable(
	
	id int NOT NULL IDENTITY(1,1) primary key,
	username varchar(150) not null,
	pass varchar(150) not null
)

insert into loginTable(username,pass) values ('hehe','lollol');

insert into loginTable(username,pass) values('admin.jeyason.jeyapa','Mdsuim@2');

select * from loginTable