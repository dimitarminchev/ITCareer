/* 607. Deposits Filter */
USE gringotts;

SELECT deposit_group, SUM(deposit_amount) AS total_sum
FROM wizzard_deposits
WHERE magic_wand_creator = "Ollivander family"
GROUP BY deposit_group
HAVING total_sum < 150000
ORDER BY total_sum DESC;