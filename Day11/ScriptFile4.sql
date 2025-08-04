-- Data Functions

-- GetDate() : used to display today's date 

Select GETDATE()
Go

Select convert(varchar,GETDATE(),1)
Go

Select convert(varchar,GETDATE(),2)
Go

Select convert(varchar,GETDATE(),101)
Go

Select convert(varchar,GETDATE(),103)
Go

/* DatePart() : used to display the specific portion of the given date */

Select DATEPART(dd,getdate())
Select DATEPART(mm,getdate())
Select DATEPART(yy,getdate())
Select DATEPART(hh,getdate())
Select DATEPART(mi,getdate())
Select DATEPART(ss,getdate())
Select DATEPART(ms,getdate())
Select DATEPART(dw,getdate())
Select DATEPART(qq,getdate())

-- DateName() : Displays date part in engligh words 

Select DATENAME(dw,getdate())
Go

Select convert(varchar,datepart(dd,getdate())) +'/'+
convert(varchar,datepart(mm,getdate())) +'/'+
convert(varchar,datepart(yy,getdate()))
Go

Select DATENAME(mm,GETDATE())
GO

/* DateAdd() : Used to add no.of days or months or years to the particular date */

Select DATEADD(dd,3,getdate())

Select DATEADD(mm,3,getdate())

Select DATEADD(yy,3,getdate())

/* DateDiff() : used to Display difference between Two Dates */ 

Select DATEDIFF(dd,'03/09/1980',getdate())
Select DATEDIFF(yy,'03/09/1980',getdate())