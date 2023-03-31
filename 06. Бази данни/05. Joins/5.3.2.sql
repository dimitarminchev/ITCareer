/*
Задача 5.15.* Държави без планини
Изведете списък на всички държави без нито една планина (общо би трябвало да са 231). Използвайте за целта OUTER JOIN.
*/
USE `geography`;

SELECT `country_name`
FROM `countries` AS `c`
LEFT JOIN `mountains_countries` AS `mc` 
      ON `mc`.`country_code` = `c`.`country_code`
WHERE `mc`.`mountain_id` IS NULL;
