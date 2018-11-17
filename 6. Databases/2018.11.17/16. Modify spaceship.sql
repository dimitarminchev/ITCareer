-- 16. Modify spaceship 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#16
/*
Create a user defined stored procedure with the name
udp_modify_spaceship_light_speed_rate
(spaceship_name VARCHAR(50), light_speed_rate_increse INT(11))
that receives a spaceship name and light speed increase value 
and increases spaceship light speed only if the given spaceship 
exists. If the modifying is not successful rollback any changes 
and throw an exception with error code ‘45000’ and message: 
“Spaceship you are trying to modify does not exists.” 
*/

DROP PROCEDURE IF EXISTS udp_modify_spaceship_light_speed_rate;

DELIMITER $$
CREATE PROCEDURE udp_modify_spaceship_light_speed_rate
(spaceship_name VARCHAR(50), light_speed_rate_increse INT(11))
BEGIN
	START TRANSACTION;
    IF(NOT EXISTS(
		SELECT * 
		FROM spaceships 
        WHERE name = spaceship_name
	  )) THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Spaceship you are trying to modify does not exists.';
        ROLLBACK;
	ELSE
		UPDATE spaceships
        SET light_speed_rate = light_speed_rate + light_speed_rate_increse
        WHERE name = spaceship_name;
		COMMIT;
    END IF;
END
$$

CALL udp_modify_spaceship_light_speed_rate('USS Templar', 5);
SELECT name,light_speed_rate FROM spaceships WHERE name = 'USS Templar';