--https://www.hackerrank.com/challenges/average-population-of-each-continent/
SELECT 
    Country.Continent, 
    FLOOR(AVG(City.Population)) AS AverageCityPopulation
FROM 
    Country
JOIN 
    City ON Country.Code = City.CountryCode
GROUP BY 
    Country.Continent;

