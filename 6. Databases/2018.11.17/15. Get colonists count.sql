-- 15. Get colonists count 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#15

DROP FUNCTION IF EXISTS udf_count_colonists_by_destination_planet;

DELIMITER $$
CREATE FUNCTION udf_count_colonists_by_destination_planet
(planet_name VARCHAR (30))
RETURNS INT
DETERMINISTIC
BEGIN
	DECLARE count INT;
    SET count :=
    (
		SELECT COUNT(*)
        FROM colonists AS c
        JOIN travel_cards AS tc ON tc.colonist_id = c.id
        JOIN journeys AS j ON j.id = tc.journey_id
        JOIN spaceports AS s ON s.id = j.destination_spaceport_id
        JOIN planets AS p ON p.id = s.planet_id
        WHERE p.name = planet_name
    );
    RETURN count;
END
$$

SELECT p.name, udf_count_colonists_by_destination_planet('Otroyphus') AS count
FROM planets AS p
WHERE p.name = 'Otroyphus';

