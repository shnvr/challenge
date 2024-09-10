--https://www.hackerrank.com/challenges/weather-observation-station-5
-- Query for the shortest city name
SELECT TOP 1 
    CITY, 
    LEN(CITY) AS NameLength
FROM STATION
ORDER BY LEN(CITY), CITY;

-- Query for the longest city name
SELECT TOP 1 
    CITY, 
    LEN(CITY) AS NameLength
FROM STATION
ORDER BY LEN(CITY) DESC, CITY;
