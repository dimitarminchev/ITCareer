/* 
Задача 5.7. Държави без планини
Изведете списък на всички държави без нито една планина (общо би трябвало да са 231).
*/
USE `geography`;

/* v1 */
SELECT DISTINCT `country_name`
FROM `countries` AS `c`
LEFT JOIN `mountains_countries` AS `mc` ON `mc`.`country_code`=`c`.`country_code` 
WHERE `mc`.`mountain_id` NOT IN 
(
	SELECT `id`
    FROM `mountains`
    WHERE `mountains`.`id` = `mc`.`mountain_id`
);

/* v2 */
SELECT `country_name` 
FROM `countries`
WHERE `country_code` NOT IN 
(
	SELECT DISTINCT `country_code` 
    FROM `mountains_countries`
);