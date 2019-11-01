/* 08.	Намерете цялата информация за служители */
use soft_uni;
SELECT 
employee_id as id,
first_name as `First Name`,
last_name as `Last Name`,
middle_name as `Middle Name`,	
job_title as `Job Title`,
department_id as `DeptID`,
manager_id as `Mngr`,
hire_date as `HireDate`,
salary,	address_id
FROM employees
WHERE job_title = 'Sales Representative';