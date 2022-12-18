/* 6.3.1. Депозитни суми за семейство Ollivander */
USE `gringotts`;

SELECT `deposit_group`, 
       SUM(`deposit_amount`) AS `total_sum`
FROM `wizzard_deposits` AS `w`
WHERE `magic_wand_creator` = "Ollivander family"
GROUP BY `deposit_group`
ORDER BY `deposit_group` ASC;