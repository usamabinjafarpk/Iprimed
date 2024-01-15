select * from authors
select state,count(*) as 'Authors Count' from authors group by state
select state,count(*) as 'Authors Count' from authors group by state having count(*)>1
select state,count(*) as 'Authors Count' from authors group by state having count(*)>1 order by [Authors Count]
select * from sales
select stor_id,sum(qty) as 'Total Qty' from sales group by stor_id
select stor_id,sum(qty) as 'Total Qty' from sales group by stor_id having sum(qty)>50
select state,count(*) as 'Authors Count' from authors where contract=1 group by state
select state,count(*) as 'Authors Count' from authors where contract=1 group by state order by [Authors Count]