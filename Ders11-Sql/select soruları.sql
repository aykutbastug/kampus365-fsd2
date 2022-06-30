--country'si Brazil, USA, Spain olan müşterilerin listesini dönen cümle. listede görünecek kolonlar (CompanyName, ContactName, Address, Country)
select CompanyName, ContactName, Address, Country from Customers where Country = 'Brazil' or Country='USA' or Country='Spain'

--country'si Brazil, USA, Spain olan müşterilerin listesini dönen cümle. (IN kullanılarak)
select * from dbo.Customers where Country in ('Brazil','USA','Spain')

--Region değeri hiç girilmemiş yani boş olan müşterilerin listesini dönen metot
select * from dbo.Customers where Region is null


--Region değeri hiç girilmemiş yani boş olanlar hariç müşterilerin listesini dönen metot
select * from dbo.Customers where Region is not null


--Region değeri hiç girilmemiş yani boş olan müşterilerin ilk 10 tanesinin listesini dönen metot
select top 10 * from dbo.Customers where Region is null
select top(10) * from dbo.Customers where Region is null


--Şirket ismi en uzun olan müşteriyi dönen select cümlesi
select top 1 CompanyName, LEN(CompanyName) as KarakterSayisi 
from Customers
order by KarakterSayisi desc

select top 1 * from (
	select CompanyName, LEN(CompanyName) as KarakterSayisi from dbo.Customers
) as a order by KarakterSayisi desc


--A harfi ile başlayan müşterilerin listesini, harf sılaramasına göre sıralı olarak dönen cümle
select * from Customers where CompanyName like 'An%' order by CompanyName asc  --An ile başlayan kayıtları döner
select * from Customers where CompanyName like '%n' order by CompanyName asc --n ile biten kayıtları döner
select * from Customers where CompanyName like '%An%' order by CompanyName asc --içinde An geçen kayıtların listesini döner

--doğum yılı 1968 ve 1937 olan personel listesini dönen cümle
select * from dbo.Employees
where YEAR(BirthDate)=1968 or YEAR(BirthDate)=1937


select * from 
(select FirstName, LastName, Title, YEAR(BirthDate) as DogumYili from dbo.Employees) as TabloAdi
where TabloAdi.DogumYili in (1968, 1937) 
order by TabloAdi.DogumYili desc


--Tarih verisinin parçalanarak alınabilmesi
select GETDATE() AS TamTarih, YEAR(GETDATE()) as [Yıl], MONTH(GETDATE()) as Ay, DAY(GETDATE()) as [Gün]
select 
DATEPART(YEAR, GETDATE()) as Yil, 
DATEPART(HOUR, GETDATE()) AS Saat, 
DATEPART(MINUTE, GETDATE()) AS Daika, 
DATEPART(SECOND, GETDATE()) AS Saniye,
DATEPART(MILLISECOND, GETDATE()) as Msaniye

--Doğum günü bugün olan personellerin listesini dönen cümle
select * from dbo.Employees
where DAY(BirthDate)=DAY(GETDATE()) and MONTH(BirthDate)=MONTH(GETDATE())


--ürün fiyatı 50 ile 80 arasında olanların listesi
select * from dbo.Products where UnitPrice>=50 and UnitPrice<=80
select * from dbo.Products where UnitPrice between 50 and 80


--9. aydaki siparişlerin listesini dönen select cümlesi
select * from Orders where OrderDate between '2022-09-01' and '2022-09-30'
select * from Orders where OrderDate between '20220901' and '20220930'

--en pahalı olan ürünü dönen sql cümlesi
select top 1 * from Products order by UnitPrice desc
select * from Products where UnitPrice=(select MAX(UnitPrice) from Products)

--en ucuz 5 ürünü dönen sql cümlesi
select top 5 * from Products order by UnitPrice asc


--en ucuz 5 ürünün fiyatının ortalaması
select AVG(YeniTablo.UnitPrice) from (
select top 5 UnitPrice from dbo.Products order by UnitPrice asc) as YeniTablo

select SUM(YeniTablo.UnitPrice)/5 from (
select top 5 UnitPrice from dbo.Products order by UnitPrice asc) as YeniTablo

--SP-[OrderId] şeklinde sipariş numarası listesini dönen cümle
select 'SP-' + Convert(varchar, OrderID) as [Sipariş No], OrderID, OrderDate from Orders
select 'CUST-' + CompanyName as [Yeni İsim], * from Customers


--ShippedDate yılı 1997 olan kaç ADET siparişim var
select COUNT(*) as [Sipariş Sayısı] from dbo.Orders where YEAR(ShippedDate)=1997

--Freight değeri 100 ve üzerinden olan siparişlerin Müşteri Adı, Ülkesini dönen sql cümlesi
select C.CompanyName, C.Country, O.OrderDate, O.OrderID from dbo.Orders as O
inner join dbo.Customers as C on C.CustomerID=O.CustomerID
where O.Freight >= 100 


--10436 OrderId li siparişte satılan ürünlerin Adını, Kategorisinin Adı, Miktarını dönen sql cümlesi
--dbo.Orders
--dbo.OrderDetails
--dbo.Products
--dbo.Categories

select  P.ProductName, C.CategoryName, OD.Quantity

from dbo.Orders as O
inner join dbo.OrderDetails as OD on OD.OrderID=O.OrderID
inner join dbo.Products as P on P.ProductID=OD.ProductID
inner join dbo.Categories as C on C.CategoryID=P.CategoryID
inner join dbo.Customers as CU on CU.CustomerID=O.CustomerID
--where O.OrderID=10436
where CU.CompanyName='Hanari Carnes'
