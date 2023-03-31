/* 
Задача 4.20. Служители и техните мениджъри
Изведете справка, показваща списък на името и фамилията на всеки служител и имената на неговия мениджър. За тези, които нямат такъв, изведете "(no manager)". Сортирайте резултата по имената на мениджъра, в азбучен ред.
*/
USE `soft_uni`;
(
    /* managers */
	SELECT `first_name`, `last_name`, 'No manager' as `manager_name` 
	FROM `employees`
	WHERE `manager_id` IS NULL
)
UNION
(
    /* employees */
	SELECT `e`.`first_name`, `e`.`last_name`, concat(`m`.`first_name`,' ',`m`.`last_name`) as `manager_name` 
	FROM `employees` AS `e`
	LEFT JOIN  `employees` AS `m` ON `m`.`employee_id` = `e`.`manager_id`
	WHERE `e`.`manager_id` IS NOT NULL
)
ORDER BY `manager_name`;

