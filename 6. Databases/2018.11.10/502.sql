/* 502. Longest Magic Wand */
USE gringotts;

SELECT MAX(magic_wand_size) AS `longest_magic_wand`
FROM wizzard_deposits;