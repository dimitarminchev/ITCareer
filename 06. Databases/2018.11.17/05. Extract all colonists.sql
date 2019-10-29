-- 05. Extract all colonists 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#5

SELECT id, CONCAT(first_name, ' ', last_name) AS full_name, ucn
FROM colonists
ORDER BY first_name, last_name, id;