INSERT INTO `travel_cards` (`card_number`, `job_during_journey`, `colonist_id`, `journey_id`)
SELECT  CASE 
            WHEN `c`.`birth_date` > '1980-01-01'
            THEN concat(Year(`c`.`birth_date`),Day(`c`.`birth_date`),Left(`c`.`ucn`,4)) 
            ELSE concat(Year(`c`.`birth_date`),Month(`c`.`birth_date`),Right(`c`.`ucn`,4))
        END as `card_number`,
        CASE 
            WHEN `c`.`id` % 2 = 0 THEN 'Pilot'
            WHEN `c`.`id` % 3 = 0 THEN 'Cook'
            ELSE 'Engineer'
        END AS `job_during_journey`,
        c.id AS `colinist_id`,
        Left(`c`.`ucn`,1) AS `journey_id`
FROM `colonists` AS `c` 
WHERE `id` BETWEEN 96 AND 100