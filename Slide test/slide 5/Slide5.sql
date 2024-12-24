create database slide5Bai1C#3;
go
use slide5Bai1C#3
go
create table StudentDetails(
	Id int identity(1,1) primary key,
	NameStd varchar(50) null,
	Age int null,
	City varchar(50) null,
	Gender varchar(50) null
)
insert into StudentDetails values
	('Le Minh Huy', 23, 'Da Nang', 'Nam'),
	('Tran Van nghi', 18, 'Da Nang', 'Nam')