--Ürün Id paramatre olacak alacak
--ilgili ürünü bulup stok miktarını kontrol edecek
--20 nin altında ise 'Stok kritik seviyede' mesajı dönecek
--20 ve üzerinde ise 'Stok miktarı yeterli' mesajı döneccek

create proc KritikStokMiktarKontrolu
	@productId int
as
begin

	declare @stokMiktari int
	select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@productId

	if  (@stokMiktari < 20)
	begin
		select 'Stok kritik seviyede. Stok Miktarı=' + CONVERT(varchar, @stokMiktari)
	end
	else begin
		select 'Stok miktarı yeterli. Stok Miktarı=' + CONVERT(varchar, @stokMiktari)
	end

end


exec [dbo].[KritikStokMiktarKontrolu] 4

select * from Products