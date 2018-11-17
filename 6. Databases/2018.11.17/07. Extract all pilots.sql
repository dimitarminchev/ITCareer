-- 07. Extract all pilots 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#7

SELECT id, CONCAT(first_name, ' ', last_name) AS full_name
FROM colonists
WHERE id IN
(
	SELECT colonist_id
	FROM travel_cards
    WHERE job_during_journey = 'Pilot'
)
ORDER BY id