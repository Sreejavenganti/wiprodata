

-- Query 1: Patients admitted in the month of January
SELECT * 
FROM ROOM_ALLOCATION 
WHERE MONTH(admission_date) = 1;


-- Query 2: Female patient who is not suffering from asthma
SELECT * 
FROM PATIENT_MASTER 
WHERE gender = 'F' AND LOWER(disease) != 'asthma';

-- Query 3:Count of male and female patients
SELECT gender, COUNT(*) AS count 
FROM PATIENT_MASTER 
GROUP BY gender;

--  Query 5: Rooms never allocated to any patient
SELECT room_no 
FROM ROOM_MASTER 
WHERE room_no NOT IN (
    SELECT DISTINCT room_no FROM ROOM_ALLOCATION
);

-- Query 6: Rooms allocated more than once

SELECT RA.room_no, RM.room_type, COUNT(*) AS times_allocated
FROM ROOM_ALLOCATION RA
JOIN ROOM_MASTER RM ON RA.room_no = RM.room_no
GROUP BY RA.room_no, RM.room_type
HAVING COUNT(*) > 1;