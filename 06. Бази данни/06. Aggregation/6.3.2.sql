/*
Задача 6.7. Филтър на депозити
Изберете всички депозитни групи и общата депозитна сума, но само за тези магьосници, чиято пръчка е измайсторена от семейство Ollivander. След това филтрирайте общата депозитна сума, така че да показва само тези под 150000. Подредете резултатите по общата сума в намалящ ред.
*/
USE `gringotts`;
SELECT `deposit_group`, 
       SUM(`deposit_amount`) AS `total_sum`
FROM `wizzard_deposits` AS `w`
WHERE `magic_wand_creator` = "Ollivander family"
GROUP BY `deposit_group`
HAVING `total_sum` < 150000	
ORDER BY `total_sum` DESC;