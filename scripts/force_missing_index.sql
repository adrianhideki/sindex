select distinct object_name(object_id), rows
from sys.partitions
order by rows desc

select *
from sys.objects
where name = 'SalesOrderDetail'

select *
from sys.schemas 
where schema_id = 9

SELECT* 
FROM Sales.SalesOrderDetail
where UnitPrice BETWEEN 900 AND 1500
ORDER BY rowguid DESC