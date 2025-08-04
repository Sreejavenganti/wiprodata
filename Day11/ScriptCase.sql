Select * from Agent
Go

Select AgentId, FirstName, LastName, City, MaritalStatus
from Agent
Go

-- Write a query ensure, if MaritalStatus is 0 THEN 'Unmarried' if MartialStatus is '1' then Married 

select AgentID, FirstName, LastName, City, MaritalStatus,
Case MaritalStatus 
	When 0 Then 'Unmarried'
	When 1 Then 'Married'
END 'Marital Status'
from Agent
GO

select * from Policy
GO

select PolicyID, AppNumber, PolicyNumber, AnnualPremium, PaymentModelID,
CASE PaymentModelID
	WHEN 1 THEN 'Yearly'
	WHEN 2 THEN 'Half-Yearly'
	WHEN 3 THEN 'Quarterly'
END 'PayMode'
from Policy
Go