create database Assessment
use Assessment
create table Subject(subjectId int, subtitle varchar(20))
select * from Subject

create table Book(bookId int,
title varchar(20),
price int,
volume int, 
author varchar(20),
publishDate Date,
subjectId int
)
select * from Book

--1.	Insert 5 diff subjects in subject table
insert into Subject values(1,'English'),
(2,'Hindi'),
(3,'Malayalam'),
(4,'IT'),
(5,'Maths')

--2.	Insert 15 diff books of 5 subjects in books table
insert into Book values(100,'Abc',100,1,'abc','12.01.2023',5),
(101,'Abc',100,1,'abc','12.01.2023',1),
(102,'Bcd',199,1,'bcd','06.02.2024',1),
(103,'Cde',299,3,'cde','07.08.2021',1),
(104,'Def',200,1,'def','12.01.2023',2),
(105,'Efg',300,1,'efg','03.02.2022',2),
(106,'Fgh',400,1,'fgh','12.01.2021',2),
(107,'Ghi',150,2,'ghi','12.01.1998',3),
(108,'Hij',190,1,'hij','12.01.2000',3),
(109,'Ijk',200,1,'ijk','12.01.2021',3),
(110,'Jkl',230,2,'jkl','04.05.1999',4),
(111,'Klm',450,1,'klm','12.01.2023',4),
(112,'Lmn',320,1,'lmn','12.01.2000',4),
(113,'Mno',500,3,'mno','04.08.1999',5),
(114,'Nop',590,1,'nop','02.01.2023',5)

--3.	Write a query to retrieve the book and its subject details using inner join.
select s.subjectId,s.subtitle,b.bookId,b.title,b.price,b.volume,b.author,b.publishDate from Subject s join Book b on s.subjectId=b.subjectId

--4.	Write a query to retrieve the books list published in a given specific date interval
select * from Book where publishDate between '04.08.1999' And '12.01.2021'

--5.	Write a query to retrieve the number of books referred by each author
select author, COUNT(*) AS bookCount FROM Book GROUP BY author;

--6.	Write a query to retrieve the number of books referred by each subject
select subjectId,COUNT(*) as 'Books Count' from Book group by subjectId

--7.	Write a query to retrieve the number of books published by the year 2000
select count(*) as 'Books by Year' from Book where YEAR(publishDate)=2000

--8.	Write a query to update price and volume of a book using bookId.
update Book set price=499, volume=2 where bookId=106

--9.	Write a query to update price of English subject books 10%
update Book SET price = price * 1.1 WHERE subjectId=(select subjectId from Subject where subtitle='English')

--10.	Write a query to delete a book using bookId
delete from Book where bookId=100

--11.	Write a query to retrieve books who’s price is >500 and subject is maths.
select * from Book where price>500 and subjectId=(select subjectId from Subject where subtitle='Maths')

--12.	 Write a query to retrieve the book and its subject details with ascending order of subject.
select s.subjectId,s.subtitle,b.bookId,b.title,b.price,b.volume,b.author,b.publishDate from Subject s join Book b on s.subjectId=b.subjectId order by s.subtitle

--13.	Write a query to retrieve the min price of book details.
select * from Book where price=(select MIN(price) from Book)

--14.	Write a query to retrieve the max price of the book details 
select * from Book where price=(select max(price) from Book)

--15.	Write a query to count the no of books of subject maths.
select COUNT(subjectId) as Count from Book where subjectId=(select subjectId from Subject where subtitle='Maths')

--16.	Write a query to display books of subject english, maths and IT.
select * from Book where subjectId in (select subjectId from Subject where subtitle In ('English','Maths','IT'))

select s.subjectId,s.subtitle,b.bookId,b.title,b.price,b.volume,b.author,b.publishDate from Subject s join Book b on s.subjectId=b.subjectId where subtitle in('English','Maths','IT')

