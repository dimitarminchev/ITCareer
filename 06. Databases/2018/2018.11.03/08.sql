/* 08. Адреси с градове */
USE soft_uni;

SELECT first_name, last_name, t.name AS town, address_text
FROM employees AS e
INNER JOIN addresses AS a ON a.address_id=e.address_id
INNER JOIN towns AS t ON a.town_id=t.town_id
ORDER BY e.first_name, e.last_name 
LIMIT 5;

