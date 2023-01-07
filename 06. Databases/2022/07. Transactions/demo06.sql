-- Triger sample
DELIMITER $$
CREATE TRIGGER tr_delete_records
AFTER DELETE
ON employees_projects
FOR EACH ROW
BEGIN
	INSERT INTO employees_projects_history
	      (employee_id, project_id)
	VALUES(old.employee_id, old.project_id);
END 
$$

-- DELETE
DELETE FROM soft_uni.employees_projects 
WHERE employee_id = 3;

-- CHECK
SELECT * FROM soft_uni.employees_projects_history
WHERE employee_id = 3;