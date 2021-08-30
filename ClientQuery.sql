create table NewClient(

clientId int NOT NULL IDENTITY(1,1) primary key,
clientName varchar(250) not null,
clientPersonalRecordIdentifier bigint not null,
clientDepartment varchar(250) not null,
clientContact bigint not null,
clientEmail varchar(250) not null,
)

select * from NewClient