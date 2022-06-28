select * from dbo.Customers as c
where c.Country in (select distinct s.Country from dbo.Suppliers as s)




select o.*
,(select top 1 p.ProductName from dbo.Products p where p.ProductID=o.ProductID) as UrunAdi

from dbo.OrderDetails  as o