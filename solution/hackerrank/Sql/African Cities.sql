--https://www.hackerrank.com/challenges/african-cities
select CITY.NAME
from CITY
left join COUNTRY on COUNTRY.CODE = CITY.COUNTRYCODE
where COUNTRY.CONTINENT = 'Africa'