select * from Participants

alter table Participants add mobile varchar(1)
insert into Participants values('Anna','a@g.c','12345536')

alter table Participants alter column mobile varchar(10)

alter table Participants add constraint id_pk primary key(Pid)
sp_helpconstraint Participants

update Participants set mobile='12324421' where Pid=2