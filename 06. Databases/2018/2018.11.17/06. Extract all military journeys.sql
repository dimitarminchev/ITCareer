-- 06. Extract all military journeys 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#6

SELECT id, journey_start, journey_end
FROM journeys
WHERE purpose = 'Military'
ORDER BY journey_start