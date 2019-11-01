/* 13. Планински вериги */
USE geography;

SELECT c.country_code, c.country_name, m.mountain_range
FROM countries AS c
INNER JOIN mountains_countries AS mc ON mc.country_code = c.country_code
INNER JOIN mountains AS m ON m.id = mc.mountain_id

WHERE c.country_code IN ("US","RU","BG")
ORDER BY c.country_code, m.mountain_range;
