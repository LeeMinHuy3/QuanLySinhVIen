create database QLSinhVien
go
use QLSinhVien

create table quyen(
	iMaquyen int primary key,
	sTenquyen varchar(30)
)

create table taikhoan(
	sMatk nvarchar(50) primary key,
	sTaikhoan nvarchar(50),
	sMatkhau nvarchar(50),
	iMaquyen int references quyen(iMaquyen)
)

insert into quyen values
	(1, 'DaoTao'),
	(2, 'SinhVien'),
	(3, 'GiangVien')

insert into taikhoan values
	('1', 'daotao', 'abc123', 1),
	('2', 'giangvien', 'abc123', 3),
	('3', 'sinhvien', 'abc123', 2)

create proc proc_login
	@user nvarchar(50),
	@pass nvarchar(50)
as
begin
	select * from taikhoan where sTaikhoan = @user and sMatkhau = @pass
end