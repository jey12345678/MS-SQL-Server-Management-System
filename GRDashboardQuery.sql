create table GRDashboards(

id int NOT NULL IDENTITY(1,1) primary key,
clientIdentifier bigint not null,
clientName varchar(250) not null,
clientDepartment varchar(250) not null,
clientContact bigint not null,
clientEmail varchar(250) not null,
dashboardName varchar(250) not null,
dashboardIssueDate varchar(250) not null,
dashboardReturnDate varchar(250),

)

select * from GRDashboards