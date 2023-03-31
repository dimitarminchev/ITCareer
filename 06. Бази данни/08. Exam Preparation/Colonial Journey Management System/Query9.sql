SELECT 
	`s`.`name` AS 'spaceship_name', 
	`sp`.`name` AS 'spaceport_name'
FROM `spaceships` AS `s`
LEFT JOIN `journeys` AS `j` ON `j`.`spaceship_id` = `s`.`id`
LEFT JOIN `spaceports` AS `sp` ON `sp`.`id` = `j`.`destination_spaceport_id`
ORDER BY `s`.`light_speed_rate` DESC 
LIMIT 1;