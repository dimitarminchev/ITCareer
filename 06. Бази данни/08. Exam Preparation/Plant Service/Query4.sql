-- 4: Потребители без поръчки
SELECT 
     IF
     (
		`u`.`last_name` IS NULL,
        `u`.`first_name`,
        CONCAT(`u`.`first_name`, ' ', `u`.`last_name`)
     ) AS `full_name`,
    `u`.`username` AS `username`,
    `c`.`name` AS `city`,
    YEAR(`u`.`register_date`) AS `register_year`

FROM
    `users` AS `u`,
    `cities` AS `c`

WHERE
    `u`.`city_id` = `c`.`id` AND 
    `u`.`id` NOT IN 
    (
		SELECT `user_id`
		FROM `orders`
    )
    
ORDER BY 
	`register_year` ASC , 
	`full_name` ASC;