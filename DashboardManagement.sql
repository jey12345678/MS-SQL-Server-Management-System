create table NewDashboard(
	dId int NOT NULL IDENTITY(1,1) primary key,
	dName varchar(250) not null,
	dCreatorName varchar(250) not null,
	dGroup varchar(250) not null,
	dPubl varchar(250) not null,
	img varchar(1000) not null
)

select * from NewDashboard


