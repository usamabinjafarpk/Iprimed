select * from Employee
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e left outer join Dept d on e.Dept_code=d.Dept_code
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e right outer join Dept d on e.Dept_code=d.Dept_code
select e.Id,e.Name,e.joinDate,e.salary,d.Dept_Name from Employee e full outer join Dept d on e.Dept_code=d.Dept_code

--cross join
select e.Name,d.Dept_Name from Employee e,Dept d