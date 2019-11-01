/* 10. Служители с близки до най-ниските заплати */
USE soft_uni;

/* Пример 1 */
SELECT e.first_name, e.last_name, e.salary FROM employees e 
WHERE e.salary < 1.1 * 
  (SELECT salary FROM employees ORDER BY salary LIMIT 1) 
ORDER BY salary;

/* Пример 2 */
SELECT first_name,last_name,salary
FROM employees
WHERE salary IN
(
  SELECT DISTINCT salary 
  FROM employees 
  WHERE salary BETWEEN 
               (SELECT salary FROM employees ORDER BY salary ASC LIMIT 1) AND
              ((SELECT salary FROM employees ORDER BY salary ASC LIMIT 1)*1.1)
  ORDER BY salary ASC
);