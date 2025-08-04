create proc prcShowPaySlip
                          @empno INT
AS
BEGIN
              Declare
			        @name Varchar(30),
					@sal numeric(9,2),
					@tax numeric (9,2),
					@takehome numeric (9,2)
              BEGIN
			  if exists (select *from Employ where empno = @empno)
			  BEGIN
			         Select @name = name, @sal = Basic, 
					 @tax = dbo.fncommission(basic),
					 @takehome = Basic - dbo.fncommission(basic)
					 from Employ where Empno = @empno
					 Print 'Hi Mr/Miss/Mrs' +@name
					 print 'Your Salary is' +Convert(varchar,@sal)
					 Print 'Your tax to be paid' +convert(varchar,@tax)
					 Print 'You take home' +convert(varchar,@takehome)
			End
			Else
			BEGIN
			       Print 'Employ Record not Found'
			End
			End
ENd
Go

Exec prcShowPaySlip 2
Go