--https://www.hackerrank.com/challenges/weather-observation-station-11
SELECT DISTINCT CITY
FROM STATION
WHERE CITY NOT LIKE '[AEIOU]%'
   OR CITY NOT LIKE '%[AEIOU]';
