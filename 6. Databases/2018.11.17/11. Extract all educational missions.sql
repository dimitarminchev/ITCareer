-- 11. Extract all educational missions
-- https://judge.softuni.bg/Contests/Practice/Index/1265#11

SELECT pl.name AS planet_name, p.name AS spaceport_name
FROM planets AS pl
JOIN spaceports AS p ON p.planet_id = pl.id
JOIN journeys AS j ON j.destination_spaceport_id = p.id
WHERE j.purpose = 'Educational'
ORDER BY p.name DESC;