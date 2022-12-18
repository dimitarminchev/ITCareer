/* 6.4.3. Първа буква */
USE `gringotts`;

SELECT LEFT(`first_name`, 1) AS `first_letter`
FROM `wizzard_deposits`
WHERE `deposit_group` = 'Troll Chest' 
group by `first_letter`
ORDER BY `first_letter`;