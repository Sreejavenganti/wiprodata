-- Display Macthing records from Employ and LeaveHistory

Select * from Employ where Empno = ANY(Select Empno from LeaveHistory)

-- Display matching records from Agent and AgentPolicy Tables 

Select * from Agent where AgentId = ANY(Select AgentId from AgentPolicy)

-- Display matching records from Policy and AgentPolicy Tables 

Select * from Policy where PolicyId = ANY(Select PolicyId from AgentPolicy)


-- Display Employ Details who are not taken Leave (Means records which are in Employ table, but not in LeaveHistory Table)

Select * from Employ where Empno <> ALL(Select Empno from LeaveHistory)


 -- Display Idle Agents (AgentId Exists in Agent Table, but not in AgentPolicy Table) 

 Select * from Agent where AgentId <> ALL(Select AgentId from AgentPolicy)


 -- Display Idle Policies (PolicyId exists in Policy Table, but not in AgentPolicy Table) 

 Select * from Policy where PolicyId <> ALL(Select PolicyId from AgentPolicy)
