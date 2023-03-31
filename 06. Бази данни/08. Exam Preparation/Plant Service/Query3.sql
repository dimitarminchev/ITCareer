-- 3: Растения от семейство
SELECT 
    `plants`.`id`, 
    `plants`.`name`, 
    `info_plants`.`family`, 
    `info_plants`.`genus`

FROM 
    `plants`, 
    `info_plants`

WHERE 
    `plants`.`id` = `info_plants`.`plant_id` AND 
    `quantity` > 0 AND 
    `family`="Poaceae"

ORDER BY 
    `genus` ASC, 
    `name` ASC;