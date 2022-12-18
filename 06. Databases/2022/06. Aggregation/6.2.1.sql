/* 6.2.1. Най-дългата магическа пръчка по депозитна група*/
USE `gringotts`;

SELECT `deposit_group`, MAX(`magic_wand_size`) AS `longest_magic_wand`
FROM `wizzard_deposits` AS `w`
GROUP BY `deposit_group`
ORDER BY `deposit_group`;