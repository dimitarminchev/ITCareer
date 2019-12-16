SELECT deposit_group, AVG(`wizzard_deposits`.`magic_wand_size`) AS `AverageWandSize`
FROM gringotts.wizzard_deposits
GROUP BY deposit_group
ORDER BY AverageWandSize LIMIT 1;