/* 03. Планините в България */
USE geography;

SELECT m.mountain_range, p.peak_name, p.elevation
FROM mountains AS m
LEFT JOIN peaks AS p ON p.mountain_id = m.id 
LEFT JOIN mountains_countries AS mc ON mc.mountain_id = m.id
WHERE mc.country_code="BG" AND
(
	p.id IS NULL OR p.id = 
	(
		SELECT id 
        FROM peaks 
		WHERE mountain_id = m.id 
		ORDER by elevation 
        DESC LIMIT 1
	)
)
ORDER BY elevation DESC;