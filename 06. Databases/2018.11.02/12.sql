/* 12. Служителите от San Francisco */
USE soft_uni;

SELECT e.first_name, e.last_name
FROM employees e 
WHERE e.address_id in 
(
   SELECT address_id 
   FROM addresses
   WHERE town_id = 
   (
      SELECT town_id 
      FROM towns 
      WHERE name = "San Francisco"
   )
)
ORDER BY e.first_name, e.last_name