-- 2: Потребители без фамилия
SELECT 
    `id`, 
    `username`, 
    `first_name`, 
    `age`, 
    CONCAT(DAY(`register_date`),"-",MONTH(`register_date`)) AS `register_day_month` 

FROM 
    `users`

WHERE 
    `last_name` IS NULL AND 
    `age` < 60

ORDER BY 
    `age` ASC,
    `username` ASC;