create database QuanLy
use QuanLy

create table Groups(
	GroupID int primary key,
	GroupName nvarchar(20)
)

create table Users(
	UserID int primary key,
	UserName nvarchar(20),
	GroupID int references Groups(GroupID)
)

insert into Groups values 
	(1, 'Member'),
	(2, 'Moderator'),
	(3, 'Super Moderator'),
	(4, 'Admin')

insert into Users values
	(1, 'Adon', 1),
	(2, 'Akuma', 2),
	(3, 'Balrog', 1),
	(4, 'Bison', 1),
	(5, 'Blanka', 3),
	(6, 'Cammy', 1),
	(7, 'ChunLi', 1),
	(8, 'Cody', 4),
	(9, 'Dan', 1),
	(10, 'DeeJay', 1)