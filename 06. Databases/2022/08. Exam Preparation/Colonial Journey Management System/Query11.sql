SELECT 
	`p`.`name` AS 'planet_name', 
	COUNT(`p`.`name`) AS 'journeys_count'
FROM `planets` AS `p`
LEFT JOIN `spaceports` AS `sp` ON `sp`.`planet_id` = `p`.`id`
LEFT JOIN `journeys` AS `j` ON `j`.`destination_spaceport_id` = `sp`.`id`
GROUP BY `p`.`name`
ORDER BY COUNT(`p`.`name`) DESC, `p`.`name` ASC;