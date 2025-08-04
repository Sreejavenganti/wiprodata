Create Proc PrcEmpRaise
                               @eno INT,
							   @nam Varchar(30),
							   @gen Varchar(10),
							   @bas Numeric(9,2)
AS
BEGIN 
             Declare
			      @erNo INT
				  BEGIN TRY
				  Insert into EmployPrc values(@eno,@nam,@gen,@bas)
				END TRY
				BEGIN CATCH
				        RAISERROR('Error Occurred In Constraints please check table Definition',16,3)
                 END CATCH
END
GO

Exec PrcEmpRaise 3, 'Shiva' , 'Male', 90000
Go