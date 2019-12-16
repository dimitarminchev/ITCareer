(
	SELECT country_name, country_code, 'EURO' as 'currency'
	FROM geography.countries
	WHERE currency_code = 'EUR'
) UNION (
	SELECT country_name, country_code, 'NOT EURO' as 'currency'
	FROM geography.countries
	WHERE currency_code <> 'EUR'
)
ORDER BY country_name ASC;

