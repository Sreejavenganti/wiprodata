select *from Employ
Go

Create Function EmployTabEx() Returns @EmployTab Table
(
         Empno INT,Name Varchar(30), Basic numeric(9,2)
)
AS
Begin
           Insert into @EmployTab
		             Select Empno,Name,Basic from Employ
			Return
End
Go

Select * from dbo.EmployTabEx();
