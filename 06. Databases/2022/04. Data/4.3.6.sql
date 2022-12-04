USE `geography`;

SELECT 
	`mountains`.`mountain_range`,
	`peaks`.`peak_name`,
	`peaks`.`elevation` 
    
FROM `peaks`, `mountains`

WHERE `mountains`.`id` = `peaks`.`mountain_id` AND 
`mountains`.`id` IN
(
	SELECT `mountain_id`
	FROM `mountains_countries` 
	WHERE `country_code`="BG"	
) 
ORDER BY `elevation` DESC;