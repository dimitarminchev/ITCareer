/* 22. Планините в България */
USE geography;

(
    /* Планини в България и височините им */
	SELECT mountain_range,  
	(
		SELECT peak_name 
        FROM peaks 
        WHERE mountain_id = m.id 
        ORDER by elevation DESC 
        LIMIT 1
	) AS peak_name,
	(
		SELECT elevation 
        FROM peaks 
        WHERE mountain_id = m.id 
        ORDER by elevation 
        DESC LIMIT 1
	) AS elevation
	FROM mountains m  
	WHERE id IN 
    (
		SELECT mountain_id 
        FROM mountains_countries 
        WHERE country_code = 'BG'
	) 
    AND id IN 
    (
		SELECT DISTINCT mountain_id 
        FROM peaks
	)
)
UNION
(
	/* Планини в България без информация за тях */
	SELECT mountain_range,"no","info"
	FROM mountains m  
	WHERE id IN 
    (
		SELECT mountain_id 
        FROM mountains_countries 
        WHERE country_code = 'BG'
	)
	AND NOT EXISTS 
    (
		SELECT 1 
        FROM peaks 
        WHERE mountain_id = m.id
	)
)
ORDER BY mountain_range