/* 
Задача 5.16. Планините в България 
Напишете заявка, която изброява планини в България и за всяка - най-високия ѝ връх и неговата височина. Заявката да е сортирана по височината на планините, от най-високата към най-ниската. За целта използвайте  OUTER JOIN.
*/
USE `geography`;

SELECT `m`.`mountain_range`,`p`.`peak_name`, `p`.`elevation`
FROM `peaks` AS `p`
LEFT JOIN `mountains` AS `m` ON `m`.`id` = `p`.`mountain_id`
LEFT JOIN `mountains_countries` AS `mc` ON `mc`.`mountain_id`=`m`.`id`

WHERE  `mc`.`country_code`  = "BG"
ORDER BY `p`.`elevation` DESC;

