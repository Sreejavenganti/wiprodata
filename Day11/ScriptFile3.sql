-- String Functions

/* charindex() : Used to display the first occurence of the given character  */

Select CHARINDEX('l','hello')
Go

Select Nam, CHARINDEX('a',nam) from Emp
Go

/* Reverse() : Used to display string in reverse order */

Select REVERSE('Sreeja')
Go

Select Nam, REVERSE(Nam) from Emp
Go

/* Len() : Display length of a string */

Select Len('Sreeja')
Go

Select Nam, Len(Nam) from Emp
Go

/* Left() : Display no.of left side chars */
Select left('Satyanarayana',5)
Go

/* Right() : Display no.of Right side chars */
Select right('Satyanarayana',8)
Go


/* Upper() : Display string in Uppercase */

Select nam, UPPER(nam) from Emp
Go

/* Lower() : Display string in Lowercase */

Select nam, Lower(nam) from Emp
Go

/* Substring() : used to Display a part from string */

Select SUBSTRING('welcome to sql',5,8)
Go

/* Replace() : used to replace a old value/string */

Select REPLACE('Dotnet Training', 'dotnet','java')
Go