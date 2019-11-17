/* Брой служители по департаменти */
SELECT d.`name` AS `Department`, COUNT(e.salary) AS `Total`
FROM soft_uni.employees AS e
LEFT JOIN soft_uni.departments AS d ON e.department_id = d.department_id
GROUP BY e.department_id
ORDER BY Total DESC;
