-- 7: Поръчки от род
SELECT 
	`users`.`id`, 
	`users`.`first_name`,
	COUNT(`orders`.`id`) AS `orders`

FROM 
	`users`, 
	`orders`

WHERE
	`users`.`id` = `orders`.`user_id` AND 
	`users`.`id` IN
	(
		SELECT 
			`user_id` 

		FROM 
			`orders`
		WHERE 
			`id` IN
			(
				SELECT 
					`order_id` 
				
				FROM 
					`plants_orders`

				LEFT JOIN 
					`info_plants` ON
					 `info_plants`.`plant_id` = `plants_orders`.`plant_id` 

				WHERE
					`info_plants`.`genus` = "Begonia"
			)
	)

GROUP BY
	`users`.`id`

ORDER BY 
	`orders` DESC, 
	`first_name` ASC;
