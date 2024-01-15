create database TrainingDB
use TrainingDB
create table ParticipantList
(
	Pid bigint identity(1,1)  not null,
	PName varchar(20),
	Email varchar(20)
	)

insert into ParticipantList values('Usama','usama@gmail.com')

select * from ParticipantList

sp_rename 'ParticipantList','Participants'

select * from Participants

sp_rename 'Participants.PName','FirstName'