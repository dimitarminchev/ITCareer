-- 5: Получени поръчки
SELECT 
    `u`.`id` AS `id`, 
    CONCAT(`u`.`first_name`) as `first_name`, 
    `u`.`age` AS `age`, 
    COUNT(`o`.`id`) AS `received_orders`

FROM 
    `users` AS `u`,
    `orders` AS `o`

WHERE 
    `u`.`id` = `o`.`user_id` AND 
    `is_completed` = 1

GROUP BY 
    `u`.`id`

ORDER BY
    `received_orders` DESC, 
    `first_name` ASC

LIMIT 10;