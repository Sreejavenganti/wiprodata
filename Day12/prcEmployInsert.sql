if exists(Select * from sysobjects where name = 'prcEmployInsert')
Drop Proc prcEmployInsert
Go

Create Proc prcEmployInsert
               @Name varchar(30),
			   @gender varchar(10),
			   @dept varchar(30),
			   @desig varchar(30),
			   @basic Numeric(9,2)
AS
BEGIN
        Declare
			       @empno INT
              begin
			      Select @empno = case when Max(empno) is Null Then 1 ELSE
				         Max(empno)+1 END from Employ
				  INSERT into Employ(Empno,Name,Gender,Dept,Desig,Basic)
				         Values(@empno,@name,@gender,@dept,@desig,@basic)
                  Print 'Employ Record Inserted...'
               end
END
GO
Exec prcEmployInsert 'Sreenika' , 'Female', 'Dotnet', 'Expert',88323 
Go