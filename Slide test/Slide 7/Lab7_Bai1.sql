create database Lab7
use Lab7

create table thanhvien(
	TV_ID int primary key identity,
	TV_Name nvarchar(50),
	TV_Phone varchar(13),
	TV_Email varchar(50)
)