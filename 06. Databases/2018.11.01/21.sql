/* 21. Страни и валута  (Euro / Not Euro) */
USE geography;

SELECT country_name, country_code, 

/* Пример 1 */
CASE WHEN currency_code = "EUR" THEN "EURO" ELSE "NOT EURO" END as currency1,
/* Пример 2 */
IF(currency_code="EUR","EURO","NOTEURO") as currency2

FROM countries
ORDER BY country_name;
