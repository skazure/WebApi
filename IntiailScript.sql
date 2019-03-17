CREATE TABLE [dbo].[User]
(
	[ProductId] INT NOT NULL PRIMARY KEY,
	[ProductName] varchar(50) not null,
	[Price] INT
)


CREATE TABLE [dbo].[UserTask]
(
	TaskId INT NOT NULL PRIMARY KEY,
	TaskType varchar(50) not null,
	AssignedOn varchar(50)
)


CREATE TABLE [dbo].[Reminder]
(
	RequestId INT NOT NULL PRIMARY KEY,
	ReminderType varchar(50) not null,
	ExpiringOn varchar(50)
)

select * from dbo.[User]
select * from dbo.USerTask
select * from dbo.Reminder

/*

drop table dbo.[User]
drop table dbo.USerTask
drop table dbo.Reminder

*/

insert into dbo.[User] values (1,'Indian Coffee1','120')
insert into dbo.[User] values (2,'Indian Coffee2','121')
insert into dbo.[User] values (3,'Indian Coffee3','122')
insert into dbo.[User] values (4,'Indian Coffee4','123')
insert into dbo.[User] values (5,'Indian Coffee5','124')
insert into dbo.[User] values (6,'Indian Coffee6','125')

insert into dbo.UserTask values (1,'Approval1','01.01.2019')
insert into dbo.UserTask values (2,'Approval2','01.01.2019')
insert into dbo.UserTask values (3,'Approval3','01.01.2019')
insert into dbo.UserTask values (4,'Approval4','01.01.2019')
insert into dbo.UserTask values (5,'Approval5','01.01.2019')
insert into dbo.UserTask values (6,'Approval6','01.01.2019')

insert into dbo.Reminder values (1,'Change1','01.01.2019')
insert into dbo.Reminder values (2,'Change2','01.01.2019')
insert into dbo.Reminder values (3,'Change3','01.01.2019')
insert into dbo.Reminder values (4,'Change4','01.01.2019')
insert into dbo.Reminder values (5,'Change5','01.01.2019')
insert into dbo.Reminder values (6,'Change6','01.01.2019')

