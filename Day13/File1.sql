Create proc prcDivision
             @a INT,
			 @b INT
AS
BEGIN 
        BEGIN TRY
		    SET @a = 5;
			SET @b = @a /0
			Print @b
	    END TRY
		BEGIN CATCH
		          Print 'Error is'
				  Print ERROR_MESSAGE()
        END CATCH
END
GO

Exec prcDivision 14,0
Go


Create proc prcEvenCheck
              @n INT
AS
BEGIN 
       Declare 
	         @res INT
          BEGIN TRY
			 SET @res = @n%2
			 if(@res = 0)
			 BEGIN
			      PRINT 'No Error'
				  PRINT 'Even Number'
              END
			  ElSE
			  BEGIN;
			       PRINT 'ERROR OCCURED'
				   Throw [ 70000, ERROR OCCURED, 5]
              END
	    END TRY
		BEGIN CATCH
		         Print 'Error_Message()'
		END CATCH
END