-- 10. Extract - pilots younger than 30 years
-- https://judge.softuni.bg/Contests/Practice/Index/1265#10

SELECT sh.name, sh.manufacturer
FROM spaceships AS sh
JOIN journeys AS j ON j.spaceship_id = sh.id
JOIN travel_cards AS tc ON tc.journey_id = j.id
JOIN colonists AS c ON c.id = tc.colonist_id
WHERE tc.job_during_journey = 'Pilot'
AND 2019 - YEAR(c.birth_date) < 30
ORDER BY sh.name;