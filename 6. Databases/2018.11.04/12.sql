/* 12. Най-високи върхове в България */
USE geography;

SELECT mc.country_code, m.mountain_range, p.peak_name, p.elevation
FROM peaks AS p
INNER JOIN mountains AS m ON p.mountain_id = m.id
INNER JOIN mountains_countries AS mc ON mc.mountain_id = m.id 

WHERE elevation >= 2835 and mc.country_code="BG"
ORDER BY elevation DESC;
