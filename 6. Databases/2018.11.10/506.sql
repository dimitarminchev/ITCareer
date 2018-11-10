/* 506. Deposits Sum for Ollivander family */
USE gringotts;

SELECT deposit_group, SUM(deposit_amount) AS total_sum
FROM wizzard_deposits
WHERE magic_wand_creator = "Ollivander family"
GROUP BY deposit_group
ORDER BY deposit_group;
