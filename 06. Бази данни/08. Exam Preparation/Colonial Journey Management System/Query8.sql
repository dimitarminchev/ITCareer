SELECT 
	`c`.`id`, 
	CONCAT(`c`.`first_name`,' ',`c`.`last_name`) AS `full_name`
FROM `colonists` AS `c`
JOIN `travel_cards` AS `tc` ON `tc`.`colonist_id` = `c`.`id`
WHERE `tc`.`job_during_journey` = 'Pilot'
ORDER BY `c`.`id`;