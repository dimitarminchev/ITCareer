/* Задача 5.8. Адреси с градове*/
USE `soft_uni`;
SELECT `e`.`first_name`, `e`.`last_name`, `t`.`name` AS `town`, `a`.`address_text`
FROM `employees` AS `e`
INNER JOIN `addresses` AS `a` ON `a`.`address_id` = `e`.`address_id`
INNER JOIN `towns` AS `t` ON `t`.`town_id` = `a`.`town_id`
ORDER BY `e`.`first_name`, `e`.`last_name`
LIMIT 5;