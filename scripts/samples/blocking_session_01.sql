use AdventureWorks2017;

BEGIN TRAN;

UPDATE Product WITH (TABLOCK)
   SET Name = 'Adjustable Race'
from Production.Product
where Name LIKE '%Adjustable Race%'

WAITFOR DELAY '00:00:30'

ROLLBACK;