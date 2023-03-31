/*
Задача 3.7. Намерете цялата информация за служители
Напишете SQL заявка, за да намерите цялата информация за служителите, чиято длъжност е "Търговски представител" ( Sales Representative ). Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.)
*/
SELECT 
	`employee_id` as "id",
	`first_name` as "First Name",
	`last_name` AS "Last Name",
    `middle_name` AS "Middle Name",
	`job_title` AS "Job Title",
	`department_id` AS "DeptID",
	`manager_id` AS "Mngr ID",
    `hire_date` AS "HireDate",
	`salary`,`address_id`
FROM `soft_uni`.`employees`
WHERE `job_title` = 'Sales Representative';