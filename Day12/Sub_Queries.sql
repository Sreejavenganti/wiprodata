SELECT TOP (1000) [Empno]
      ,[Name]
      ,[Gender]
      ,[Dept]
      ,[Desig]
      ,[Basic]
  FROM [wiprojuly].[dbo].[Employ]

  Select Max(Basic) From Employ;

  select name from Employ where basic = (Select Max(Basic) From Employ)
  Go

    -- Dispaly second max. salary 

	
  select Max(Basic) from Employ where basic < (Select Max(Basic) From Employ)
  Go

  -- Display Name of employ who is getting 2nd max. salary


  select name from Employ where basic = (select Max(Basic) from Employ where basic < (Select Max(Basic) From Employ))
  Go

  Select * from Policy;

  Select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  ROW_NUMBER() OVER (ORDER BY AnnualPremium Desc) Rno
  from Policy
  Go

  Select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  RANK() OVER (ORDER BY AnnualPremium Desc) Rno
  from Policy
  Go

  Select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  DENSE_RANK() OVER (ORDER BY AnnualPremium Desc) Rno
  from Policy
  Go

  Select * from Policy
  Go

  Select MAX(AnnualPremium) from Policy

  -- Display PolicyID of max. annualpremium 

  Select PolicyId from Policy where AnnualPremium = ( Select MAX(AnnualPremium) from Policy)

  -- Display 2nd max AnnualPremium 

  Select MAX(AnnualPremium) from Policy where AnnualPremium < (Select MAX(AnnualPremium) from Policy)
