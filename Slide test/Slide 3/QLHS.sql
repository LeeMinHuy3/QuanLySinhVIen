create database QLHOCSINH
use QLHOCSINH

create table HOCSINH(
	MaHS nvarchar(10) primary key,
	TenHS nvarchar(255),
	NgaySinh date,
	DiaChi nvarchar(255),
	DTB float,
	MaLop nvarchar(10) foreign key (MaLop) references LOP(MaLop)
)

create table LOP(
	MaLop nvarchar(10) primary key,
	TenLop nvarchar(255),
	SiSo int
)
select * from lop