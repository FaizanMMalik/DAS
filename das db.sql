Create Database das
Create Table appt(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name varchar(50),
Surname varchar(50),
Email varchar(50),
PhoneNo varchar(50),
Message varchar (max),
adate date,
)

select *from appt