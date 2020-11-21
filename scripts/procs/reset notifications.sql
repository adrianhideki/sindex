EXEC dbo.st_GetNotifications

INSERT INTO dbo.notification(
 update_date
,extract_date
,notify_type
,notify_desc
,quantity
)
SELECT update_date = GETDATE()
      ,extract_date = CAST(GETDATE() AS Date)
      ,notify_type = 'Aviso'
      ,notify_desc = 'ERROOOO'
      ,quantity = 1

delete from notification

UPDATE notification
   SET quantity = 0
FROM notification