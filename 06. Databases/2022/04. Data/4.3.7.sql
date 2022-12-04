USE `geography`;

SELECT  `mountain_range`
FROM `mountains`
WHERE `mountains`.`id` IN (
		SELECT `mountain_id`
		FROM `mountains_countries` 
		WHERE `country_code`="BG"	
) AND `mountains`.`id` NOT IN 
(
    SELECT DISTINCT `mountain_id`
    FROM `peaks`
    WHERE `mountain_id` IN (
		SELECT `mountain_id`
		FROM `mountains_countries` 
		WHERE `country_code`="BG"	
	)
);
