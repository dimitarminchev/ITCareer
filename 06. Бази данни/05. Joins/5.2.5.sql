/* Задача 5.12. Най-високи върхове в България */
USE `geography`;

SELECT `mc`.`country_code`, `m`.`mountain_range`, `p`.`peak_name`, `p`.`elevation`
FROM `peaks` AS `p`
INNER JOIN `mountains` AS `m` ON `m`.`id` = `p`.`mountain_id`
INNER JOIN `mountains_countries` AS `mc` ON 
(
	`mc`.`mountain_id` = `p`.`mountain_id` AND
    `mc`.`country_code` = "BG"
)
WHERE `p`.`elevation` >= 2835
ORDER BY `p`.`elevation` DESC;