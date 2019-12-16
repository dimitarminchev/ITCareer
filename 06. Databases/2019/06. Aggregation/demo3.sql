/* Минимална заплата на отделите с над 20 работници */
SELECT d.`name` AS `Department`, 
      MIN(e.salary) AS `Minimum`, 
      COUNT(e.salary) as `Counter` 
FROM soft_uni.employees AS e
LEFT JOIN soft_uni.departments AS d ON d.department_id = e.department_id
GROUP BY e.department_id
HAVING `Counter` >= 20;