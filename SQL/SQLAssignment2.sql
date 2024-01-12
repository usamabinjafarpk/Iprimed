use Assignment
create table Department(
	Dept_no varchar(5) primary key,	Dept_name varchar(20) not null,	location varchar(20) not null)select * from Departmentinsert into Department values('d1', 'Research', 'Dallas'),('d2', 'Accounting' ,'Seattle'),('d3' ,'Marketing', 'Dallas')