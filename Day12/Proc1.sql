if exists(Select *from sysobjects where name = 'PrcSayHello')
Drop Proc PrcSayHello
Go

Create proc PrcSayHello
AS
BEGIN
      Print 'WELCOME TO T-Sql'
END
GO

Exec PrcSayHello
Go