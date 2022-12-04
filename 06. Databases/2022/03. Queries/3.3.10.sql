/* 3.3.10 */
SELECT concat(`first_name`," ",`middle_name`," ",`last_name`) AS "full_name"
FROM `soft_uni`.`employees`
WHERE `salary` in (25000, 14000, 12500, 23600);