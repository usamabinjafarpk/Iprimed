Create TABLE Department
(
Dept_no varchar(20) Primary key not null,
Dept_name varchar(30) not null,
lOCATION vARCHAR(30) NOT NULL
);

Create TABLE Employee(
emp_no int Primary key not null,
emp_fname varchar(30) not null,
emp_lname varchar(30) not null,
dept_no varchar(20),
Constraint const_fk Foreign key(dept_no) REFERENCES Department(Dept_no) 
ON DELETE cascade);
 
CREATE TABLE Project(
Project_no varchar(10) pRIMARY KEY NOT NULL,
Project_name varchar(30) NOT NULL,
Budget BIGINT NOT NULL
);

create table Works_on(
emp_no int not null,
project_no varchar(10),
Job varchar(30),
enter_date datetime not null,
Constraint const_fk_1 Foreign key(emp_no) REFERENCES Employee(emp_no) 
ON DELETE cascade,
Constraint const_fk_2 Foreign key(project_no) REFERENCES Project(Project_no) 
ON DELETE cascade
)
 
-- Insert values into the Department table
INSERT INTO Department (Dept_no, Dept_name, location) VALUES
('d1', 'Research', 'Dallas'),
('d2', 'Accounting', 'Seattle'),
('d3', 'Marketing', 'Dallas');
-- Insert values into the Employee table
INSERT INTO Employee (emp_no, emp_fname, emp_lname, dept_no) VALUES
(25348, 'Matthew', 'Smith', 'd3'),
(10102, 'Ann', 'Jones', 'd3'),
(18316, 'John', 'Barrimore', 'd1'),
(29346, 'James', 'James', 'd2');
-- Insert values into the Project table
INSERT INTO Project (project_no, project_name, Budget) VALUES
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600);
-- Insert values into the Works_on table
insert into Works_on values(10102,'p1','Analyst','1997.10.1')
insert into Works_on values(10102,'p3','manager','1997.1.1')
insert into Works_on values(25348,'p2','clerk','1998.2.15')
insert into Works_on values(18316,'p2','NULL','1998.6.1')
insert into Works_on values(29346,'p2','NULL','1997.12.15')
insert into Works_on values(18316,'p3','NULL','1998.10.15')
insert into Works_on values(25348,'p1','NULL','1998.8.1')
insert into Works_on values(25348,'p2','clerk','1992.2.1')
insert into Works_on values(29346,'p3','clerk','1997.11.15')
insert into Works_on values(29346,'p1','clerk','1998.1.4')
-- 1. Get all rows of the works_on table.
SELECT * FROM Works_on;
-- 2. Get the employee numbers for all clerks.
SELECT emp_no FROM Employee WHERE emp_no IN (SELECT emp_no FROM Works_on WHERE Job = 'Clerk');

-- 3. Get the employee numbers for employees working in project p2 and having employee numbers smaller than 10000.
SELECT emp_no FROM Works_on WHERE project_no = 'p2' AND emp_no < 10000;

-- 4. Get the employee numbers for all employees who didn’t enter their project in 1998.
SELECT emp_no FROM Works_on WHERE YEAR(enter_date) != 1998;

-- 5. Get the employee numbers for all employees who have a leading job (i.e., Analyst or Manager) in project p1.
SELECT emp_no FROM Works_on WHERE project_no = 'p1' AND Job IN ('Analyst', 'Manager');

-- 6. Get the enter dates for all employees in project p2 whose jobs have not been determined yet.
SELECT enter_date FROM Works_on WHERE project_no = 'p2' AND Job IS NULL;

-- 7. Get the employee numbers and last names of all employees whose first names contain two letter t’s.
SELECT emp_no, emp_lname FROM Employee WHERE emp_fname LIKE '%t%t%';
-- 8. Get the employee numbers and first names of all employees whose last names have a letter o or a as the second character and end with the letters es.
SELECT emp_no, emp_fname FROM Employee WHERE emp_lname LIKE '_[oa]%es';
-- 9. Get the employee numbers of all employees whose departments are located in Seattle.
SELECT emp_no FROM Employee WHERE dept_no IN (SELECT Dept_no FROM Department WHERE location = 'Seattle');
-- 10. Find the last and first names of all employees who entered their projects on 04.01.1998.
SELECT emp_fname, emp_lname FROM Employee WHERE emp_no IN (SELECT emp_no FROM Works_on WHERE enter_date = '1998.1.4');
-- 11. Group all departments using their locations.
SELECT location, C(Dept_no) AS Departments FROM Department GROUP BY location;
-- 12. Find the biggest employee number.
SELECT MAX(emp_no) AS Biggest_Employee_Number FROM Employee;
-- 13. Get the jobs that are done by more than two employees.
SELECT Job FROM Works_on GROUP BY Job HAVING COUNT(Job) > 2;
-- 14. Find the employee numbers of all employees who are clerks or work for department d3.
SELECT emp_no FROM Employee WHERE dept_no = 'd3' OR emp_no IN (SELECT emp_no FROM Works_on WHERE Job = 'Clerk');
 
--II section
-- 1 Question
select * from Project
select * from Works_on
select * from Project p join Works_on w on p.project_no=w.project_no
select * from Project p left outer join Works_on w on p.project_no=w.project_no
select p.Project_name ,w.job from Project p , Works_on w
--2 Question
select * from Project
select * from Works_on
select * from Employee
select e.emp_no,w.job from Employee e join works_on w on w.emp_no=e.emp_no join project p on  p.project_name='Gemini'
--3 Question
SELECT Employee.emp_fname, Employee.emp_lname
FROM Employee
JOIN Department ON Employee.Dept_no = Department.Dept_no
WHERE Department.Dept_name IN ('Research', 'Accounting')
--4 Question

SELECT Works_on.enter_date
FROM Works_on
JOIN Employee ON Works_on.emp_no = Employee.emp_no
WHERE Employee.Dept_no= 'd1' AND Works_on.Job = 'Clerk'
--5 Question
select * from project
select * from works_on
SELECT Project_name
FROM Project p
JOIN Works_on w ON p.Project_no = w.Project_no
WHERE w.Job = 'Clerk'
GROUP BY p.project_no
HAVING COUNT(w.emp_no) >= 2;
--6 Question
SELECT e.emp_fname, e.emp_lname
FROM Employee e
JOIN Works_on w ON e.emp_no = w.emp_no
WHERE w.project_no = 'p3' AND w.Job = 'Manager'
--7 Question
select * from Employee
select * from works_on
SELECT DISTINCT E1.emp_fname, E1.emp_lname
FROM Works_on W1
JOIN Employee E1 ON W1.emp_no = E1.emp_no
JOIN Works_on W2 ON W1.enter_date = W2.enter_date AND W1.emp_no <> W2.emp_no
--8 Question
select * from Department
select * from Employee
SELECT e1.emp_no
FROM Employee e1
JOIN Department d ON e1.Dept_no = d.Dept_no AND d.location = d.location

--9 Question

SELECT emp_no
FROM Employee
WHERE Dept_no = 'd3';
--10 Question
--join
SELECT e.Emp_no
FROM Employee e
JOIN Department d ON e.Dept_no = d.Dept_no
WHERE d.Dept_name = 'Marketing'
--correlated
select * from Department
select * from Employee

SELECT emp_no
FROM Employee
WHERE Dept_no IN (
  SELECT Dept_no
  FROM Department d
  WHERE d.dept_name = 'Marketing'
)

--11 Question

INSERT INTO Employee (emp_no, emp_fname, emp_lname)
VALUES (1111, 'Julia', 'Long');
--12 Question
select * from department

--13 Question
UPDATE Works_on
SET Job = 'Clerk'
WHERE project_no = 'p1' AND Job = 'Manager';

--14 Question
UPDATE project
SET Budget = NULL;
--15 Question
UPDATE Project
SET Budget = Budget * 1.1
WHERE project_no IN (SELECT project_no FROM Works_on WHERE emp_no = 10102 AND Job = 'Manager');
--16 Question
UPDATE Works_on
SET enter_date = '1998-12-12'
WHERE project_no = 'p1' AND emp_no IN (SELECT emp_no FROM Employee WHERE Dept_no = 'Sales');
 
--17
CREATE PROCEDURE sp_InsertDepartmentAndEmployee
@dept_name NVARCHAR(255),
@Location NVARCHAR(255),
@EmployeeName NVARCHAR(255),
@EmployeePosition NVARCHAR(255) 
AS BEGIN 
-- Insert into the department table
INSERT INTO department (dept_name, Location) VALUES (@dept_name, @Location); 
-- Get the department ID of the newly inserted record
DECLARE @DepartmentID INT; 
SET @DepartmentID = SCOPE_IDENTITY(); 
-- Insert into the employee table with the corresponding department ID 
INSERT INTO employee (emp_fname, dept_no) VALUES (@EmployeeName, @DepartmentID);
END;

