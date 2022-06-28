select ProductID, COUNT(*) as Adet, SUM(UnitPrice) as ToplamUrunFiyati

from [dbo].[OrderDetails]

group by ProductID
order by ProductID, OrderID
