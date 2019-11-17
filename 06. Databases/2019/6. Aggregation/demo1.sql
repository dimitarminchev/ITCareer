/* Обща сума на дадени пари по департаменти */
SELECT d.`name` AS `Department`, SUM(e.salary) AS `Total`
FROM soft_uni.employees AS e
LEFT JOIN soft_uni.departments AS d ON e.department_id = d.department_id
GROUP BY e.department_id
ORDER BY e.department_id;
