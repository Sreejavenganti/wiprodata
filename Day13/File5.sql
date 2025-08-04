Create function fnEvenOdd(@n INT) RETURNS varchar(30)
AS
BEGIN
     if(@n%2 =0)
	 BEGIN
	        RETURN 'Even Number'
	  END
	  ELSE
	  BEGIN 
	        RETURN 'Odd Number'
	  END
	  RETURN ''
END
GO

Select dbo.fnEvenOdd(4)
Go
Select *from Employ
Go

Create function fnComission(@sal INT) RETURNS numeric(9,2)
AS
BEGIN
      RETURN @sal *0.03
END
Go

Select dbo.fnComission(10000)
Go

Select Empno, Name, Gender, Dept, Basic, dbo.fnComission(Basic) 'Commission',
                                 Basic - dbo.fnComission(Basic) 'Take Home'
from Employ
Go

Select * from Agent
Go

create function fnAgentMStat(@martialstatus INT) Returns Varchar(30)
As
BEGIN
                  Declare
				      @res varchar(30)
				if @martialstatus = 0
				BEGIN
				       set @res = 'Unmarried'
				END
				if @martialstatus = 1
				BEGIN
				       set @res = 'married'
                END
				return @res
END
GO

select dbo.fnAgentMStat(0)
GO

Select AgentId, FirstName, LastName, City, MaritalStatus, dbo.fnAgentMStat(MaritalStatus)
from Agent
Go

Select * from Policy
Go

Create function fnPaymode(@paymode INT) Returns varchar(30)
AS
BEGIN
           Declare
		        @res varchar(30)
		   if @paymode = 1
		   BEGIN
		         Set @res = 'Yearly'
            END
			if @paymode = 2
		   BEGIN
		         Set @res = 'Half-Yearly'
            END
			if @paymode = 3
		   BEGIN
		         Set @res = 'Quarterly'
            END
			return @res
End
Go

select PolicyId, AppNumber, AppDate, PaymentModeId, dbo.fnPaymode(PaymentModeId)
from Policy
go