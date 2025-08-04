SELECT TOP (1000) [EmpId]
      ,[EmployName]
      ,[MgrId]
      ,[LeaveAvail]
      ,[DateOfBirth]
      ,[Email]
      ,[Mobile]
  FROM [wiprojuly].[dbo].[Employee]

  Select E1.EmpId 'Manager Id', E1.EmployName 'Manager Name',
  E2.EmpId 'Manager Id', E2.EmployName 'Manager Name'
  from Employee E1 INNER JOIN Employee E2 On
  E1.EmpId = E2.MgrId
  Go

   Select E1.EmpId 'Manager Id', E1.EmployName 'Manager Name',
  E2.EmpId 'Manager Id', E2.EmployName 'Manager Name'
  from Employee E1 RIGHT JOIN Employee E2 On
  E1.EmpId = E2.MgrId
  Go