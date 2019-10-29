/* 18. Планините в България */
USE geography;

SELECT DISTINCT m.mountain_range, 
(
	SELECT peak_name 
    FROM peaks 
    WHERE mountain_id = m.id 
    ORDER by elevation 
    DESC LIMIT 1
) as peak_name,
(
	SELECT elevation 
    FROM peaks 
    WHERE mountain_id = m.id 
    ORDER by elevation 
    DESC LIMIT 1
) as elevation 

FROM mountains m
WHERE m.id IN 
(
	SELECT mountain_id
    FROM mountains_countries
    WHERE country_code = "BG"
)
ORDER BY elevation DESC;