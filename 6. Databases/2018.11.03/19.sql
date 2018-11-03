/* 19. Неописаните планини в България */
USE geography;

SELECT mountain_range
FROM mountains m
WHERE m.id IN 
(
   SELECT mountain_id
   FROM mountains_countries mc 
   WHERE country_code = "BG" AND mountain_id NOT IN 
   (
	  SELECT mountain_id
      FROM peaks p
      WHERE mc.mountain_id = p.mountain_id 
   )
)
ORDER BY mountain_range;