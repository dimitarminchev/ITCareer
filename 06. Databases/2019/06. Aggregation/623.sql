SELECT deposit_group, SUM(`wizzard_deposits`.deposit_amount) AS `total_sum`
FROM gringotts.wizzard_deposits
GROUP BY deposit_group
ORDER BY total_sum;