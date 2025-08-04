Select Employ.Empno, Name, Gender, Dept, Basic,
LeaveHistory.Leaveid,LeaveStartDate, LeaveEnddate
from Employ INNER JOIN LeaveHistory
ON Employ.Empno = LeaveHistory.EmpNo

Select E.Empno, Name, Gender, Dept, Basic,
LH.Leaveid,LeaveStartDate, LeaveEnddate
from Employ E INNER JOIN LeaveHistory LH
ON E.Empno = LH.EmpNo

Select A.AgentId,FirstName,LastName, City, State,
P.PolicyId,AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A INNER JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
INNER JOIN Policy P ON P.PolicyId = AP.AgentID

-- examples for Left Outer Join

Select E.Empno, Name, Gender, Dept, Basic,
LH.Leaveid,LeaveStartDate, LeaveEnddate
from Employ E Left JOIN LeaveHistory LH
ON E.Empno = LH.EmpNo

Select A.AgentId,FirstName,LastName, City, State,
P.PolicyId,AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A LEFT JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
INNER JOIN Policy P ON P.PolicyId = AP.AgentID


-- Examples for Right Outer Join

Select E.Empno, Name, Gender, Dept, Basic,
LH.Leaveid,LeaveStartDate, LeaveEnddate
from Employ E RIGHT JOIN LeaveHistory LH
ON E.Empno = LH.EmpNo

Select A.AgentId,FirstName,LastName, City, State,
P.PolicyId,AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
INNER JOIN Policy P ON P.PolicyId = AP.AgentID

-- Example For Full Join

Select A.AgentId,FirstName,LastName, City, State,
P.PolicyId,AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A FULL JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
INNER JOIN Policy P ON P.PolicyId = AP.AgentID

-- Cross Join

Select * from Agent CROSS JOIN AgentPolicy

Select * from Policy CROSS JOIN AgentPolicy