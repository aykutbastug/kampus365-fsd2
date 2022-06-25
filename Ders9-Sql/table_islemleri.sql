create table dbo.Kisiler(
	[Id] int identity(1,1) not null,
	[AdiSoyadi] varchar null,
	[Meslek] varchar(25) not null
)on [PRIMARY]

--alter table dbo.Kisiler alter column AdiSoyadi varchar(50)

--alter table dbo.Kisiler add Yas int not null

--alter table dbo.Kisiler drop column Yas

--drop table dbo.Kisiler