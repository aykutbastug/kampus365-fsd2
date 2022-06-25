--delete from dbo.Musteriler where Id=5
--delete from dbo.Musteriler
--truncate table dbo.Musteriler

--select GETDATE()

select * from dbo.Musteriler


--insert into dbo.Musteriler select 'Aykut','Baştuğ','aykut.bastug@codeove.com',GETDATE(),NULL
--insert into dbo.Musteriler ([Adi], [Soyadi], [Email], [YeniKolon], [DogumTarihi]) values ('adi','soayadi','email','', NULL)
--insert into dbo.Musteriler values ('adi2','soayadi2','email2', NULL,'dsfsdf')
--insert into dbo.Musteriler ([Adi], [Soyadi], [Email], DogumTarihi) values ('adi3','soayadi3','email3', '20081228')

--update dbo.Musteriler set Adi='adi1', Soyadi='soyadi1', DogumTarihi='1986-06-01 10:35:54.080' where Id=205
--update dbo.Musteriler set Adi='adi1', Soyadi='soyadi1', DogumTarihi='19861224' where Id=205