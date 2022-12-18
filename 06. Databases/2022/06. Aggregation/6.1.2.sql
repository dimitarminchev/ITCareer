/* 6.1.2. Най-дългата магическа пръчка */
USE `gringotts`;

SELECT MAX(`magic_wand_size`) AS `longest_magic_wand`
FROM `wizzard_deposits`;