select * from employee
select * from sales
select max(qty) from sales
select * from sales where qty=(select max(qty) from sales)
select * from sales where qty=(select min(qty) from sales)
select max(ord_date) from sales
select * from sales where ord_date=(select max(ord_date) from sales)
select count(*) as cnt from sales where ord_date=(select max(ord_date) from sales)
select * from sales where qty<(select MAX(qty) from sales)
select * from stores
select * from sales where stor_id=(select stor_id from stores where stor_name='News & Brews')
select * from sales where stor_id in (select stor_id from stores where stor_name in ('News & Brews','Bookbeat'))
select * from sales where qty>all(select qty from sales where stor_id=7131)
select * from sales where qty>(select max(qty) from sales where stor_id=7131)