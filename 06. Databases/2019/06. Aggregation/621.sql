SELECT deposit_group,MAX(`wizzard_deposits`.`magic_wand_size`) AS `longest_magic_wand`
FROM gringotts.wizzard_deposits
GROUP BY deposit_group
ORDER BY longest_magic_wand;