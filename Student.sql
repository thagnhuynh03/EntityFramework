Create database EntityDB
go
Create table Faculty
(
	FacultyId int Identity(1,1) primary key,
	FacultyName nvarchar(100)
)
go
Create table Student
(
	StudentId int identity(1,1) Primary key,
	StudentName nvarchar(100),
	StudentAge int,
	StudentGender varchar(3),
	FacultyId int,
	foreign key (FacultyId) references Faculty(FacultyId)
)
Insert into Faculty
Values
(N'Công nghệ số'), (N'Cơ khí'), (N'Điện - Điện tử')
Insert into Student
Values
(N'Huỳnh Kim Thắng', 20, 'Nam', 1),
(N'Hoàng Văn Sơn', 20, 'Nam', 1),
(N'Trần Phương Trúc', 23, 'Nữ', 2),
(N'Nguyễn Thị Huỳnh Anh', 22, 'Nữ', 3)