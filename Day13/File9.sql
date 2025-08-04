select *from Employ
Go

select * from LeaveHistory
Go

Create function FnEmpLeaveHistory() Returns @EmpLeave TABLE
(
         Empno INT, Name Varchar(30), Basic Numeric(9,2),leaveId Int,
		 LeaveStartDate Date, LeaveEndDate Date, Lop INT
)
AS
BEGIN
       Insert into @EmpLeave
	   Select E.Empno,Name,Basic,LeaveId, LeaveStartDate ,LeaveEndDate, LossOfPay
	   from Employ E INNER JOIN LeaveHistory LH ON E.Empno = LH.EmpNo
	   Return
ENd
Go

Select * from dbo.FnEmpLeaveHistory()
go