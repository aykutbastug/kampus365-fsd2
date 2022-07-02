create TRIGGER UrunStokMiktariniGuncelle_Delete
   ON  OrderDetails
   AFTER DELETE
AS 
BEGIN
	declare @productId int, @quantity smallint

	select @productId=ProductID, @quantity=Quantity from deleted

	update dbo.Products set UnitsInStock=UnitsInStock+@quantity where ProductID=@productId

END
GO
