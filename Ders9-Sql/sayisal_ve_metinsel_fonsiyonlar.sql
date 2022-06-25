--select  distinct Country from dbo.Customers order by Country
--update Employees set BirthDate='19880625' where EmployeeID=8

--select * from [dbo].[Employees] where DAY(BirthDate)=DAY(GETDATE()) and MONTH(BirthDate) =MONTH(GETDATE())

--select EmployeeID, FirstName + ' ' + LastName as [Adı Soyadı] from [dbo].[Employees]

--select * from dbo.Employees where City like 'Lo%'
--select * from dbo.Employees where City like '%on'
--select * from dbo.Employees where City like '%on%'

--update dbo.Orders set OrderDate=replace(convert(varchar,OrderDate, 23), '1996','2022')

--select OrderDate, replace(convert(varchar,OrderDate, 23), '1998','2022') from dbo.Orders

--select * from dbo.Orders where OrderDate not between '20220602' and '20220617'

--select * from dbo.Orders where OrderDate between '20220602' and '20220617'

--select convert(varchar, year(GETDATE())) + convert(varchar, month(DATEADD(Month, -2, GETDATE())))+'01'


--SELECT DATEADD(month, DATEDIFF(month, 0, DATEADD(Month, -2, GETDATE())), 0)

--select * from dbo.Orders where OrderDate between DATEADD(month, DATEDIFF(month, 0, DATEADD(Month, -2, GETDATE())), 0) and GETDATE()

--select COUNT(*) from Orders

--select *, (UnitPrice * Quantity) - Discount as TotalCost from OrderDetails

--select  SUM((UnitPrice * Quantity) - Discount) as TotalCost from OrderDetails where OrderID=10248  --Varsa koşullara uygun satırların ilgili kolona ait toplam değerini bulur

--select AVG(UnitPrice) from OrderDetails --varsa koşullara uygun satırların ilgili kolona ait ortalama değerini verir

--select MAX(UnitPrice) from OrderDetails --varsa koşullara uygun satırların ilgili kolonundaki en büyük değeri verir
--select MAX(UnitPrice) from OrderDetails where ProductID=51


--select MIN(UnitPrice) from OrderDetails --varsa koşullara uygun satırların ilgili kolonundaki en küçük değeri verir
--select MIN(UnitPrice) from OrderDetails where ProductID=51


select LEN('deneme')
select UPPER('deneme'), LOWER('DenEme')

select *, LEN(ProductName) as ProductNameLenght from dbo.Products