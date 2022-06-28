select prod.ProductID, prod.ProductName, cat.CategoryName, prod.UnitPrice, sup.CompanyName from 

dbo.Products as prod
inner join dbo.Categories as cat on cat.CategoryID=prod.ProductID
inner join dbo.Suppliers as sup on sup.SupplierID=prod.SupplierID

--where cat.CategoryName='Dairy Products'
--where sup.CompanyName='Exotic Liquids'
order by prod.ProductName

--___________________________________________________________________________


select prod.ProductID, prod.ProductName, cat.CategoryName, prod.UnitPrice 

from dbo.Products as prod
left join dbo.Categories as cat on cat.CategoryID=prod.ProductID
order by prod.ProductName

--___________________________________________________________________________

select prod.ProductID, prod.ProductName, cat.CategoryName, prod.UnitPrice 

from dbo.Products as prod
right join dbo.Categories as cat on cat.CategoryID=prod.ProductID
order by prod.ProductName

--___________________________________________________________________________

select prod.ProductID, prod.ProductName, cat.CategoryName, prod.UnitPrice 

from dbo.Products as prod
full outer join dbo.Categories as cat on cat.CategoryID=prod.ProductID
order by prod.ProductName