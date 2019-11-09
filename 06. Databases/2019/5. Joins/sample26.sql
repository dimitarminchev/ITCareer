/* Problem 6. Планински вериги */
SELECT 
	mc.country_code, 
    c.country_name, 
    m.mountain_range 

FROM mountains_countries AS mc

INNER JOIN mountains AS m
	ON m.id = mc.mountain_id
    
INNER JOIN countries AS c
	ON c.country_code = mc.country_code
    AND c.country_code IN ("BG","US","RU")
    
ORDER BY mc.country_code, m.mountain_range;