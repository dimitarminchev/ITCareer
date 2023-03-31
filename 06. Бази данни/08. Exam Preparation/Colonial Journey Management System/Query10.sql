SELECT 
	`p`.`name` AS 'planet_name', 
	`sp`.`name` AS 'spaceport_name'
FROM `planets` AS `p`
LEFT JOIN `spaceports` AS `sp` ON `sp`.`planet_id` = `p`.`id`
LEFT JOIN `journeys` AS `j` ON `j`.`destination_spaceport_id` = `sp`.`id`
WHERE `j`.`purpose` = 'Educational'
ORDER BY `sp`.`name` DESC;