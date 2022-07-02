alter TRIGGER UrunStokMiktariniGuncelle
   ON  OrderDetails
   AFTER INSERT
AS 
BEGIN
	declare @productId int, @quantity smallint

	select @productId=ProductID, @quantity=Quantity from inserted

	update dbo.Products set UnitsInStock=UnitsInStock-@quantity where ProductID=@productId

END
GO
