/* 603. Longest Magic Wand per Deposit Groups */
USE gringotts;

SELECT deposit_group, 
       MAX(magic_wand_size) AS `longest_magic_wand`
FROM wizzard_deposits
GROUP BY deposit_group;