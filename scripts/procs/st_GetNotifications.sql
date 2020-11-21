CREATE PROCEDURE dbo.st_GetNotifications @Initial_Date DateTime = NULL
                                        ,@Finish_Date  DateTime = NULL
AS
BEGIN
  SET NOCOUNT ON;

  SELECT @Initial_Date = CAST(ISNULL(@Initial_Date,CAST(GETDATE() AS date)) AS Date)
        ,@Finish_Date  = CAST(ISNULL(@Finish_Date, CAST(GETDATE() AS date)) AS Date);

  SELECT notification_id
        ,update_date
        ,extract_date
        ,notify_type
        ,notify_desc
        ,quantity
  FROM dbo.[notification]
  WHERE extract_date BETWEEN @Initial_Date AND @Finish_Date
END