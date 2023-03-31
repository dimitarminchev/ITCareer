DELETE FROM `colonists` 
WHERE `colonists`.`id` NOT IN 
(
    SELECT `tc`.`colonist_id` 
    FROM `travel_cards` AS `tc`
);