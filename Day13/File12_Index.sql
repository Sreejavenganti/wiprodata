Create Table DummyEx
(
    Eno INT,
	Name Varchar(30),
	Sal Numeric(9,2)
)
Go

Insert into DummyEx(Eno,Name,Sal) Values
            (12,'Sreeja',82245),
		    (7,'Uday',82111),
			(3,'Charishma',81144),
			(18,'Pallavi',81455),
			(15,'Nitin',88155) 
	GO

	Select * from DummyEx
	Go

	Create Clustered Index Idx_Empno
	      ON DummyEx(Eno)
	Go

	create nonClustered Index Idx_policy
	      On AgentPolicy(AgentId)
		  GO

    create nonClustered Index Idx_agent
	      On AgentPolicy(AgentId)
		  GO