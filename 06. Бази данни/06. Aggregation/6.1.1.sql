/*
Задача 6.1. Брой на записите
Импортирайте базата данни Gringotts и изведете общият брой записи. Уверете се, че нищо не остава скрито-покрито.
*/
USE `gringotts`;
SELECT COUNT(*) AS `Count`
FROM `wizzard_deposits`;