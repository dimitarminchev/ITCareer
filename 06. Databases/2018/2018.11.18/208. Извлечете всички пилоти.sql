-- 208. Извлечете всички пилоти
USE colonial_journey_management_system_db;

SELECT id, CONCAT(first_name, ' ', last_name) AS full_name
FROM colonists
WHERE id IN
(
	SELECT colonist_id
	FROM travel_cards
    WHERE job_during_journey = 'Pilot'
)
ORDER BY id