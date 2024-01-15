create database Assignment
use Assignment
--Question 1
create table Customer(
	Customerid char(5) not null,
	CompanyName varchar(40) not null,
	contactName char(30) null,
	Address varchar(60) null,
	City char(15) null,
	Phone char(24) null,
	Fax char(24) null
)
select * from Customer

create table Orders(
	OrderId integer not null,
	customerId char(5) not null,
	Orderdate datetime null,
	Shippeddate datetime null,
	Freight money null,
	Shipname varchar(40) null,
	Shipaddres varchar(60) null,
	Quantity integer null
)
select * from Orders

--Question 2

ALTER TABLE Orders ADD shipregion int null

--Question 3
ALTER TABLE Orders ALTER COLUMN shipregion char(8)

--Question 4
ALTER TABLE Orders DROP COLUMN shipregion

--Question 5
INSERT INTO Orders VALUES( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)

--Question 6
alter table Orders add default getdate() for [Orderdate]

--Question 7
SP_RENAME 'Customer.City','Town'


