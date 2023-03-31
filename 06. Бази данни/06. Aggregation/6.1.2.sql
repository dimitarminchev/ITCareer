/*
Задача 6.2. Най-дългата магическа пръчка
Изберете размера на най-дългата магическа пръчка. Преименувайте новата колона по подходящ начин.
*/
USE `gringotts`;
SELECT MAX(`magic_wand_size`) AS `longest_magic_wand`
FROM `wizzard_deposits`;