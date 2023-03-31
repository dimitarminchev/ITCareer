/*
Задача 5.21. Най-висок връх и най-дълга река по държава
За всяка държава, намерете височината на най-високия връх и дължината на най-дългата река, сортирани по височина на най-високия връх (от най-висок към най-нисък), после по дължина на най-дългата река (от най-дълга до най-къса), после по име на държавата (по азбучен ред). Покажете NULL когато за някоя от колоните не са намерени данни. Ограничете се само до първите 5 реда.
*/
USE `geography`;
	
SELECT	`c`.`country_name`,
		MAX(`p`.`elevation`) AS 'highest_peak_elevation', 
		MAX(`r`.`length`) AS 'longest_river_length' 
 
FROM `countries` AS `c`

LEFT JOIN `mountains_countries` AS `mc` ON `mc`.`country_code` = `c`.`country_code`
LEFT JOIN `peaks` AS `p` ON `p`.`mountain_id` = `mc`.`mountain_id`
LEFT JOIN `countries_rivers` AS `cr` ON `cr`.`country_code` = `c`.`country_code`
LEFT JOIN `rivers` AS `r` ON `r`.`id` = `cr`.`river_id`

GROUP BY `c`.`country_name`
ORDER BY `highest_peak_elevation` DESC, `longest_river_length` DESC, `c`.`country_name` ASC

LIMIT 5;