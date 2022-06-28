select City from dbo.Customers
union
select City from dbo.Suppliers

--_______________________________________________

select City from dbo.Customers
union all
select City from dbo.Suppliers