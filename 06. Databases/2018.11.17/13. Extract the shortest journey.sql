-- 13. Extract the shortest journey 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#13

SELECT j.id, pl.name AS planet_name, port.name AS spaceport_name, j.purpose AS journey_start
FROM journeys AS j
JOIN spaceports AS port ON port.id = j.destination_spaceport_id
JOIN planets AS pl ON port.planet_id = pl.id
WHERE j.id = 
(
	SELECT jr.id
    FROM journeys AS jr
    ORDER BY DATEDIFF(jr.journey_start, jr.journey_end) DESC 
    LIMIT 1
)