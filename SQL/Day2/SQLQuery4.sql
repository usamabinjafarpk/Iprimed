use TrainingDB
select * from [TrainingDB].[dbo].[Dept]
insert into Dept(Dept_code,Dept_Name) values('D003','Product'),('D004','Sales')
select * from Employee
insert into Employee(Id,Name,joinDate,salary,Dept_code) values(31,'varun',GETDATE(),89000,'D002'),
(22,'Ram',GETDATE(),89000,'D003'),
(33,'Ranjith',GETDATE(),81000,'D003'),
(44,'Rohan',GETDATE(),86000,'D001'),
(55,'Arya',GETDATE(),89400,'D001'),
(54,'Aman',GETDATE(),89010,'D002'),
(34,'Mic',GETDATE(),89777,'D002'),
(23,'Monca',GETDATE(),89000,'D003'),
(12,'Nidhin',GETDATE(),69000,'D001'),
(29,'Hani',GETDATE(),89000,'D002'),
(28,'Amal',GETDATE(),79000,'D001'),
(56,'Anna',GETDATE(),89000,'D002'),
(67,'Angela',GETDATE(),85000,'D002'),
(78,'Bince',GETDATE(),83000,'D003')
insert into Employee(Id,Name,joinDate,salary,Dept_code) values(30,'Akhil',GETDATE(),89000,null),(20,'Jesfer',GETDATE(),89000,null)
select * from Dept