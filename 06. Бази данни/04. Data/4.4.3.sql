/*
Задача 4.22. Планините в България
Напишете заявка, която изброява всички планини в България и за всяка - най-високия ѝ връх и неговата височина. Ако липсва информация за някой връх, вместо това да се изведе текста „no info”. Заявката да е сортирана по азбучен ред на планините.
*/
USE `geography`;
(
    /* Планинска верига, връх и височина */
	SELECT `mountains`.`mountain_range`,
	(
		SELECT `peak_name` 
		FROM `peaks`
		WHERE `mountains`.`id` = `peaks`.`mountain_id` 
		ORDER BY `elevation` DESC
		LIMIT 1
	) as `peak_name`,
	(
		SELECT `elevation` 
		FROM `peaks`
		WHERE `mountains`.`id` = `peaks`.`mountain_id` 
		ORDER BY `elevation` DESC
		LIMIT 1
	) as `elevation`
	FROM `mountains` 
	LEFT JOIN `peaks`  ON `mountains`.`id` = `peaks`.`mountain_id`
	WHERE `mountains`.`id` IN 
	(
		SELECT `mountain_id`
		FROM `mountains_countries`
		WHERE `mountains`.`id` = `mountains_countries`.`mountain_id` AND  `country_code` = "BG" 
	) 
	AND `peaks`.`peak_name` IS NOT NULL
)
UNION
(
    /* Планинска верига, връх и височина */
	SELECT `mountains`.`mountain_range`, "no" as `peak_name`, "info" as `elevation`
	FROM `mountains` 
	LEFT JOIN `peaks`  ON `mountains`.`id` = `peaks`.`mountain_id`
	WHERE `mountains`.`id` IN 
	(
		SELECT `mountain_id`
		FROM `mountains_countries`
		WHERE `mountains`.`id` = `mountains_countries`.`mountain_id` AND  `country_code` = "BG" 
	) 
	AND `peaks`.`peak_name` IS NULL
)