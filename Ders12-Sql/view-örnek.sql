Create view [dbo].[MusteriTasimaUcretleri]
as
select C.CompanyName as [Müşteri Adı], C.CustomerID AS [Müşteri Id], O.OrderID as [Sipariş No], O.OrderDate as [Sipariş Tarihi], O.Freight as [Taşıma Ücreti] 

from dbo.Orders as O
inner join dbo.Customers as C on C.CustomerID=O.CustomerID
