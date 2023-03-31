/*
Задача 4.18. Планините в България 
Напишете заявка, която изброява планини в България и за всяка - най-високия ѝ връх и неговата височина. Заявката да е сортирана по височината на планините, от най-високата към най-ниската.
*/
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