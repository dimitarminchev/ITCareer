/* 23. Всички географски обекти в България */
USE geography;

(
	/* Върхове в България */
	SELECT p.peak_name as name, "peak" AS type, p.elevation AS info 
    FROM peaks p 
	WHERE p.mountain_id IN   
    (
		SELECT mountain_id 
        FROM mountains_countries 
        WHERE country_code = 'BG'
	)
)
UNION
(
	/* Реки в България */
	SELECT r.river_name, "river", r.length 
    FROM rivers r 
	WHERE id IN 
	(
		SELECT river_id 
        FROM countries_rivers 
        WHERE country_code = 'BG'
	)
) 
UNION 
(
    /* Планини в България */
	SELECT m.mountain_range, "mountain", 
	(
		SELECT elevation 
        FROM peaks 
        WHERE mountain_id = m.id 
        ORDER by elevation 
        DESC LIMIT 1
	) elevation
	FROM mountains m  
	WHERE id IN 
	(
		SELECT mountain_id 
        FROM mountains_countries 
        WHERE country_code = 'BG'
	)
)

ORDER BY name;