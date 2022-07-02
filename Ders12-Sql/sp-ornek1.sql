ALTER PROCEDURE PersonelOlustur 
	@Adi nvarchar(10),
	@Soyadi nvarchar(20),
	@Title nvarchar(30),
	@City nvarchar(15)
AS
BEGIN
	declare @sonuc varchar(100)

	if ((select count(*) from dbo.Employees where FirstName=@Adi and LastName=@Soyadi) > 0)
	begin
		set @sonuc = @Adi + ' ' + @Soyadi + ' isimli personel sistemde zaten kayıtlı..'
	end
	else begin
		insert into dbo.Employees (LastName, FirstName, Title, City) values (@Soyadi, @Adi, @Title, @City)
		set @sonuc = @Adi + ' ' + @Soyadi + ' isimli personel kayıt edildi..'
	end


	select @sonuc as [Sonuç]

END



exec PersonelOlustur 'Aykut','Baştuğ','Eğitmen','İstanbul'
