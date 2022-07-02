create proc dbo.KritikStokRaporu
	@KritikStokSeviyesi int
as
begin

	select 
	P.ProductName as [Ürün Adı],
	P.UnitsInStock as [Stok Miktarı],
	C.CategoryName as [Kategori Adı],
	S.CompanyName as [Tedarikçi],
	S.Phone as [Telefon]

	from dbo.Products as P 
	inner join dbo.Categories as C on C.CategoryID=P.CategoryID
	inner join dbo.Suppliers as S on S.SupplierID=P.SupplierID
	where P.UnitsInStock<@KritikStokSeviyesi

end


exec [dbo].[KritikStokRaporu] 1