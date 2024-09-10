--https://www.hackerrank.com/challenges/weather-observation-station-7
SELECT DISTINCT CITY
FROM STATION
WHERE right(CITY, 1) IN ('A', 'E', 'I', 'O', 'U');