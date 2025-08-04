Create proc PrcEmpMult
                @eno INT,
				@nam varchar(30),
				@gen varchar(30),
				@bas numeric(9,2)
AS
BEGIN 
            Declare
			         @erNo INT
			    BEGIN TRAN T1
				BEGIN TRY
				Insert into EmployPrc values(@eno,@nam,@gen,@bas)
				Update EmployPrc set Salary = Salary + 10000 where eno = @eno
				PRINT @@TRANCOUNT
				if @@TRANCOUNT>2
				BEGIN
				     Print 'both Transactions are commited..'
					 Commit Tran T1
                 END
			END TRY
			BEGIN CATCH
			          Print @@TRANCOUNT
                    if @@TRANCOUNT >=1
					    BEGIN
						    print 'NO OPERATION Commited...'
							Rollback Tran T1 
                        END

					END CATCH
END
GO

Exec PrcEmpMult 2911,'Krishna','MALE',78822
Go

