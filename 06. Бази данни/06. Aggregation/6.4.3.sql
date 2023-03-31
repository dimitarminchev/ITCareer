/*
Задача 6.10. Първа буква
Напишете заявка, която връща всички уникални първи букви от първите имена на магьосници, които имат депозит от тип Troll Chest. Подредете ги в азбучен ред. Използвайте GROUP BY за уникалност.
*/
USE `gringotts`;
SELECT LEFT(`first_name`, 1) AS `first_letter`
FROM `wizzard_deposits`
WHERE `deposit_group` = 'Troll Chest' 
group by `first_letter`
ORDER BY `first_letter`;