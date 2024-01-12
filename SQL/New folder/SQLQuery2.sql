create table Dept(Dept_code char(5) primary key,Dept_Name varchar(20) unique not null)

create table Employee(Id int primary key,Name varchar(20),joinDate Date default getdate(),
salary int check(salary>0),Dept_code char(5)
constraint Dept_code_FK foreign key(Dept_code) references Dept(Dept_code) on delete cascade
)


