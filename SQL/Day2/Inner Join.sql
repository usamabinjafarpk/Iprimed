
select * from Dept
select * from Employee
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_code=d.Dept_code
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_code=d.Dept_code order by d.Dept_Name
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_code=d.Dept_code where d.Dept_Name='Admin' order by d.Dept_Name
select COUNT(e.Id) from Employee e join Dept d on e.Dept_code=d.Dept_code where d.Dept_Name='Admin'
