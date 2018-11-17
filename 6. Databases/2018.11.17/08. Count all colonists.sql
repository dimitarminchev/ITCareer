-- 08. Count all colonists
-- https://judge.softuni.bg/Contests/Practice/Index/1265#8

SELECT COUNT(*) AS count
FROM colonists AS c
JOIN travel_cards AS tc ON tc.colonist_id = c.id
JOIN journeys AS j ON j.id = tc. journey_id
WHERE j.purpose = 'Technical';