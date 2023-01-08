-- 1: Всички растения
SELECT 
    `id`,
    `name`,
    `price` 

FROM 
    `plants`

WHERE 
    `quantity` > 10 AND 
    `price` > 15

ORDER BY 
    `price` DESC, 
    `name` ASC
    
LIMIT 30; 