alter proc StokYeterliMi
	@productId int,
	@miktar int
as
begin

	declare @stokMiktari int
	select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@productId

	if (@miktar > @stokMiktari)
	begin
		select 0
	end
	else begin
		select 1
	end

end

GO

alter proc dbo.SiparisOlustur
	@OrderID int,
	@ProductID int, 
	@UnitPrice money, 
	@Quantity smallint, 
	@Discount real
as
begin

	declare @stokYeterliMi smallint
	exec @stokYeterliMi= dbo.StokYeterliMi @ProductID, @Quantity

	if (@stokYeterliMi = 1)
	begin
		
		if ((select COUNT(*) from dbo.OrderDetails where OrderID=@OrderID and ProductID=@ProductID) > 0)
		begin
			update dbo.OrderDetails set Quantity=Quantity+@Quantity where OrderID=@OrderID and ProductID=@ProductID
			select 'Sipariş güncellendi'
		end
		else begin
			insert into [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) values (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)
			select 'Sipariş oluşturuldu'
		end
	end
	else begin
		select 'Stok miktarı yeterli değil..'
	end
end



exec dbo.SiparisOlustur 10248, 8, 56, 2, 0