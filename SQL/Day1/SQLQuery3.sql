use TrainingDB

create table student(
[sid] int,
[name] varchar(30) not null,
class varchar(30) not null,
section char(1) not null,
mobile varchar(20),
constraint com_pk primary key([sid],mobile)
)

insert into student values(1,'usama','10','A',0987654321)
insert into student values(2,'Amal','10','A',0987654321)

select * from student

create table person()