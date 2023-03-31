/* Задача 5.1. Адрес на служител */
USE `soft_uni`;

/* v1 */
SELECT `employee_id`, `job_title`, `e`.`address_id`, `address_text`
FROM `employees` AS `e`
JOIN `addresses` AS `a` ON `a`.`address_id` = `e`.`address_id`
ORDER BY `e`.`address_id` ASC 
LIMIT 5;

/* v2 */
SELECT `employee_id`, `job_title`, `e`.`address_id`, `address_text`
FROM `employees` AS `e`, `addresses` AS `a` 
WHERE `a`.`address_id` = `e`.`address_id`
ORDER BY `e`.`address_id` ASC 
LIMIT 5;