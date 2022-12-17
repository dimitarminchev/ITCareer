/* 5.3.3. Планините в България  */
USE `geography`;

SELECT `m`.`mountain_range`,`p`.`peak_name`, `p`.`elevation`
FROM `peaks` AS `p`
LEFT JOIN `mountains` AS `m` ON `m`.`id` = `p`.`mountain_id`
LEFT JOIN `mountains_countries` AS `mc` ON `mc`.`mountain_id`=`m`.`id`

WHERE  `mc`.`country_code`  = "BG"
ORDER BY `p`.`elevation` DESC;

