select distinct object_name(object_id), rows
from sys.partitions
order by rows desc

select *
from sys.indexes
where name LIKE '%SalesOrderDetail%'

select *
from sys.schemas 
where schema_id = 9

drop index IX_SalesOrderDetail_ProductID ON Sales.SalesOrderDetail
drop index IX_SalesOrderDetail_UnitPrice ON Sales.SalesOrderDetail


SELECT* 
FROM Sales.SalesOrderDetail
where UnitPrice BETWEEN 900 AND 1500
ORDER BY rowguid DESC