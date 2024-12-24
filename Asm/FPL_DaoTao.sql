create database FPL_DaoTao
use FPL_DaoTao

create table USERLOGIN(
	username varchar(50) primary key not null,
	passwords varchar(50),
	roles nvarchar(50)
)

create table GRADE(
	ID int primary key identity,
	MASV varchar(50) references student(MASV),
	Tienganh float,
	Tinhoc float,
	GDTC float
)

create table STUDENT(
	MASV varchar(50) primary key not null,
	Hoten nvarchar(50),
	Email varchar(50),
	Sdt varchar(50),
	Gioitinh nvarchar(5),
	Diachi nvarchar(50),
)

insert into STUDENT values
	('pd12312', 'Le Minh Huy', 'huylm@gmail.com', '091312391', 'Nam', 'Da Nang')

select * from STUDENT
select * from GRADE
select * from userlogin