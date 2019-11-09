/* Problem 5. Най-високи върхове в България */
SELECT mc.country_code, m.mountain_range, p.peak_name, p.elevation

FROM mountains as m

INNER JOIN mountains_countries AS mc ON mc.mountain_id = m.id AND mc.country_code = "BG"
INNER JOIN peaks AS p ON p.mountain_id = m.id
    
WHERE p.elevation > 2835    
ORDER BY p.elevation DESC;