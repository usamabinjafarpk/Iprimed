select * from employee

insert into employee values(1,'usama','12.1.2023',30000,null)

insert into dept(dept_code,dept_name) values('D001','IT'),('D002','Admin')
select * from dept

insert into employee(id,name,dept_code) values(2,'asd','D001')


--update
update employee set salary=50000 where id=2
update employee set salary=60000,Dept_code='D002' where id=1
update employee set salary=salary+1000 where Dept_code='D001'

delete from employee
delete from employee where Dept_code='D002'
delete from employee where id=1