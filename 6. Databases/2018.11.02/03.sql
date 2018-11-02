/* 03. Сортирайте таблицата със служители */
USE soft_uni;

SELECT * FROM employees
ORDER BY 
salary DESC, 
first_name ASC, 
last_name ASC, 
middle_name ASC; 
