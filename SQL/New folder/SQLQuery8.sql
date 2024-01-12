select * from employee
select emp_id,fname,lname from employee
select emp_id,hire_date from employee
select emp_id,fname+' '+lname as fullname from employee
select * from employee where job_id=10
select * from employee where job_id=10 and pub_id=1389
select * from employee where job_id=10 or pub_id=1389
select * from employee where job_id in(14,10,8)
select * from employee where hire_date between '1.1.1990' and '12.2.2022'
select * from employee where job_id not in(14,10,8)
select * from authors
select * from authors where city='Oakland'
select * from employee where fname like 'p%'--start with p
select * from employee where fname like '%s'--end with s
select * from employee where fname like 'p%e'--start with p and end with e
select * from employee where fname like '%e%'--contains e
select * from employee where fname like '_e%'--second letter e
select * from employee where fname like '[kp]%'--start with k or p
select * from employee where fname not like '[kp]%'--not start with k or p
select * from employee where fname like '[^kp]%'--not start with k or p
