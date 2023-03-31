/* 
Задача 4.23. Всички географски обекти в България 
Напишете заявка, която изброява всички планини, реки и върхове в България. Заявката да съдържа името на съответния географски обект и вида му ( „mountain” за планините, “peak” за върховете и “river” за реките) и нещо най-характерно за него (за върховете - височината, за планините - височината на най-високия им връх, за реките - дължината) и да е сортирана по азбучен ред за имената на обектите.
*/
USE `geography`;
(
	/* Планински вериги */
	SELECT 	`mountain_range` as `name`, 'mountain' as `type`,
	(
	   SELECT MAX(`elevation`)
	   FROM `peaks`
	   WHERE `mountains`.`id` = `peaks`.`mountain_id`
	) as `info`
	FROM `mountains`
	WHERE `id` IN
	(
		SELECT `mountain_id`
		FROM `mountains_countries`
		WHERE `country_code` = "BG"
	)
)
UNION
(
	/* Върхове */
	SELECT `peak_name` AS `name`, "peak" as `type`, `elevation`
	FROM `peaks`
	WHERE `mountain_id` IN
	(
		SELECT `mountain_id`
		FROM `mountains_countries`
		WHERE `country_code` = "BG"
	)
)
UNION
(
	/* реки */
	SELECT `river_name` AS `name`, "river" AS `type`, `length`
	FROM `rivers`
	WHERE `id` IN
	(
		SELECT `river_id`
		FROM `countries_rivers`
		WHERE `country_code` = "BG"
	)			
)		
ORDER BY `name` ASC;		
