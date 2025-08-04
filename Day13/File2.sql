Create Table Employprc
(
        Eno INT Primary Key,
		Name varchar (30),
		Gender Varchar(10) Constraint Chk_dummy_gen check(gender in ('Male','Female')),
		Salary Numeric(9,2) constraint chk_dummy_sal check(salary between 10000 and 80000)
)
Go

Create proc PrcEmpInsNew
                          @eno INT,
						  @nam varchar(30),
						  @gen varchar(10),
						  @bas numeric(9,2)
AS
BEGIN
          Declare
		      @erNo INT
			  BEGIN TRY
			    Insert into Employprc values(@eno,@nam,@gen,@bas)
              END TRY
			  BEGIN CATCH
			          Select @erNo = ERROR_NUMBER()
					  Print 'Error Number' +convert(varchar,@erNo)
					  Print ERROR_MESSAGE()
					  Print ERROR_SEVERITY()
					  Print ERROR_LINE()
                END CATCH
END
GO

Exec PrcEmpInsNew 3, 'Shiva' , 'Male', 90000
Go