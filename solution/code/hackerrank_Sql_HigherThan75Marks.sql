--https://www.hackerrank.com/challenges/more-than-75-marks
select Name 
from Students
where Marks > 75
order by right(Name, 3), ID