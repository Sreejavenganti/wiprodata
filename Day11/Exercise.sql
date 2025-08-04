-- Exercise

-- 1) Display Last Occurrence of given char in a string


Select 
    CASE 
        WHEN CHARINDEX('a', REVERSE('UmaMaheshwar')) = 0 THEN -1
        ELSE LEN('UmaMaheshwar') - CHARINDEX('a', REVERSE('UmaMaheshwar')) + 1
    END AS LastOccurrence;


-- 2) Take FullName as 'Venkata Narayana' and split them into firstName and LastName

Select 
   'Sreeja Venganti' AS FullName ,
   LEFT('Sreeja Venganti', (CHARINDEX(' ','Sreeja Venganti'))-1) AS FirstName ,
   LTRIM(RIGHT('Sreeja Venganti', LEN('Sreeja Venganti') - (CHARINDEX(' ','Sreeja Venganti')) ) ) AS LastName


-- 3) In Word 'misissipi' count no.of 'i' 

Select LEN('misissipi') - LEN(Replace('misissipi','i','')) AS i_Count


-- 4) Display the last day of next month

Select EOMONTH(Dateadd(month, 1, getdate())) AS LastDayOfNextMonth

-- 5) Display First Day of Previous Month

Select Dateadd(DAY, 1, EOMONTH(getdate(), -2 )) AS FirstDayOfPreviousMonth


-- 6) Display all Fridays of current month

select dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	'First Friday',
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))))
	'Second Friday',
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))))
	'Third Friday',
	DATEADD(dd,7,
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))))) 
	'Fourth Friday', 
	case when Month(
		DateAdd(dd,7, 
	DATEADD(dd,7,
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))))))) 

	) = MONTH(GetDate()) THEN 
	DateAdd(dd,7, 
	DATEADD(dd,7,
	DateAdd(dd,7, 
	DATEADD(DD,7,
	dateadd(dd,
	6-datepart(dw,dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0)))))
	,
	dateadd(dd,1,dateadd(mm,-1,DATEADD(SS,-1,DATEADD(mm, DATEDIFF(mm,0,DATEADD(MM,1,GETDATE())),0))))))))) 
	ELSE 'No Fifth Friday IN this Month' END 
	'Fifth Friday'