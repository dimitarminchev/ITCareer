-- 6: Поръчки по държави
SELECT
    `query`.`name` AS `country_name`, 
    SUM(`query`.`total`) AS `total_sum`, 
    COUNT(`query`.`total`) AS `count_orders`

FROM
(
	SELECT 
        `cities`.`country_name` as `name`,
        `plants`.`price` as `total`

	FROM 
        `plants`, 
        `plants_orders`, 
        `orders`, `users`,
        `cities`
        
	WHERE 
		`plants`.`id` = `plants_orders`.`plant_id` AND
		`plants_orders`.`order_id` = `orders`.`id` AND 
		`orders`.`user_id` = `users`.`id` AND 
		`users`.`city_id` = `cities`.`id` 
) AS `query`

GROUP BY
    `query`.`name`

ORDER BY 
    `total_sum` DESC, 
    `count_orders` DESC;