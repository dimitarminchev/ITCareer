/* 1. Декатртово произведение (293 employee x 16 departmens = 4688 записа) */
USE `soft_uni`;

SELECT concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees`, `departments`;

/* 2. Присъединяване на таблица (JOIN) = 293 записа */
USE `soft_uni`;

SELECT  concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees` 
JOIN `departments` ON `departments`.`department_id` = `employees`.`department_id`;

/* 3. Задача: Всички върхове в планина Rila*/
USE `geography`;

SELECT m.`mountain_range`, p.`peak_name`, p.`elevation`
FROM `mountains` AS m
JOIN `peaks` AS p ON p.`mountain_id` = m.`id`
WHERE m.`mountain_range` = "Rila"
ORDER BY p.`elevation` DESC;

/* 4. Задача:  Покажете информация за адреса на всички служители. Изберете първите 5 служителя */
USE `soft_uni`;

SELECT e.first_name, e.last_name, t.`name` AS town, a.address_text
FROM employees AS e
INNER JOIN addresses AS a ON a.address_id = e.address_id
INNER JOIN towns AS t ON t.town_id = a.town_id
ORDER BY e.first_name, e.last_name;

/* 5. Задача: Служители по продажбите */
USE `soft_uni`;

SELECT e.employee_id, e.first_name, e.last_name, d.`name` as `department_name`
FROM employees AS e
INNER JOIN departments AS d ON d.department_id = e.department_id
WHERE d.`name` = "Sales"
ORDER BY e.employee_id DESC;

/* 6. Задача: Служители наети след дата */
USE `soft_uni`;

SELECT e.first_name, e.last_name, e.hire_date, d.`name` AS "department"
FROM employees AS e
INNER JOIN departments AS d ON 
(
  e.department_id = d.department_id
  AND DATE(e.hire_date) > '1999/1/1'
  AND d.name IN ('Sales', 'Finance')
)
ORDER BY e.hire_date ASC;