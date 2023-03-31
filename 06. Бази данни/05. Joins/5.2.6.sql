/* Задача 5.13. Планински вериги */
USE `geography`;

SELECT `mc`.`country_code`, `c`.`country_name`,	`m`.`mountain_range`
FROM `mountains_countries` AS `mc` 

INNER JOIN `countries` AS `c`  ON 
(
	`mc`.`country_code` = `c`.`country_code` AND
	`mc`.`country_code` IN ("BG", "RU", "US")
)
INNER JOIN `mountains` AS `m` ON `mc`.`mountain_id` = `m`.`id` 
ORDER BY `mc`.`country_code`, `m`.`mountain_range`;