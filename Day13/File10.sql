Create Table Student
(
  sno int constraint pk_student_sno primary key,
  name Varchar(30),
  sub1 int, sub2 int, sub3 int,
  tot int, aveg float,InsertedOn DateTime,
  InsertedBy varchar(100)
  )
  Go

  create Trigger trgStudentInsert ON Student FOR Insert
  AS
  BEGIN
        Declare
		        @sno INT
			Select @sno = sno from inserted
			Update Student set tot = sub1+sub2+sub3, aveg = (sub1+sub2+sub3)/3,
			InsertedOn  = GETDATE(), InsertedBy = SYSTEM_USER where SNo = @sno
END
Go


Insert Into Student(Sno,Name,sub1,sub2,sub3) Values (1,'Abhyansh',87,98,76)
Go

Insert Into Student(Sno,Name,sub1,sub2,sub3) Values (2,'Niskarsh',88,87,79)
Go

Insert Into Student(Sno,Name,sub1,sub2,sub3) Values (3,'Ekaksh',98,76,89)
Go

Select * from Student
Go

