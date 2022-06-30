declare @categoryId int
set @categoryId=4

--select * from dbo.Products where CategoryID=isnull(@categoryId,5)

--print @categoryId
select @categoryId as [Kategori Id]

if (@categoryId is null)
begin
	select * from dbo.Products
end
else begin
	select * from dbo.Products where CategoryID=@categoryId
end

--_____________________________________________________________

declare @orderId int
set @orderId=10436

select  P.ProductName, C.CategoryName, OD.Quantity

from dbo.Orders as O
inner join dbo.OrderDetails as OD on OD.OrderID=O.OrderID
inner join dbo.Products as P on P.ProductID=OD.ProductID
inner join dbo.Categories as C on C.CategoryID=P.CategoryID
inner join dbo.Customers as CU on CU.CustomerID=O.CustomerID
where O.OrderID=@orderId

--__________________________________________________________

declare @stokMiktari int
--set @stokMiktari=(select UnitsInStock from Products where ProductID=46)
select @stokMiktari=UnitsInStock from Products where ProductID=4

if (@stokMiktari < 20)
begin
	print 'Ürünün stok miktarı kritik seviyede'
end
else begin
	print 'Ürün stokta yeterli miktarda mevcut'
end


--___________________________________________________________


select ProductName, UnitPrice, case when UnitPrice<20 then 'Kampanyalı Ürün' end as [Kampanya Durumu] from dbo.Products
select ProductName, UnitPrice, case when UnitPrice<20 then 'Kampanyalı Ürün' else 'Kampanyasız Ürün' end as [Kampanya Durumu] from dbo.Products


select ProductName, UnitPrice, 
case when UnitPrice<20 then 'Kampanyalı Ürün' 
when UnitPrice >=20 and UnitPrice<=50 then 'İndirimli Ürün'
else 'Kampanyasız Ürün' end as [Kampanya Durumu] 
from dbo.Products


select ProductName, UnitPrice, case UnitPrice when 20 then 'Kampanyalı Ürün' end as [Kampanya Durumu] from dbo.Products


select CompanyName, City, case Country when 'UK' then 'İngiltere' when 'USA' then 'Amerika' else Country end as [Ülke] from Customers


--________________________________________________________________________________