-- Aggregate Functions 

-- sum() : used to perform sum operation 

Select Sum(basic) from Emp
Go

-- Avg() : Displays avg operation 

Select Avg(basic) from Emp
Go

Select Max(basic) from Emp
Go

Select Min(basic) from Emp
Go

-- count(*) : Displays total no.of records 

Select Count(*) from Emp
Go

-- count(column_name) : displays count for that column not null values 

Select count(basic) from Emp
Go