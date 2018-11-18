-- 201. Вмъкване на данни
USE colonial_journey_management_system_db;

INSERT INTO travel_cards(card_number, job_during_journey, colonist_id, journey_id)
SELECT 
(
	CASE
		WHEN c.birth_date > '1980-01-01' 
		THEN CONCAT(YEAR(c.birth_date), DAY(c.birth_date), SUBSTR(ucn, 1, 4))
		ELSE CONCAT(YEAR(c.birth_date), MONTH(c.birth_date), SUBSTR(ucn, 7, 10)) 
	END
) AS card_number,
(
	CASE 
		WHEN c.id % 2 = 0
			THEN 'Pilot'
		WHEN c.id % 3 = 0
			THEN 'Cook'
        ELSE 'Engineer'
	END
) AS job_during_journey,
c.id AS colonist_id,
SUBSTR(c.ucn,1,1) AS journey_id
FROM colonists AS c
WHERE c.id BETWEEN 96 AND 100