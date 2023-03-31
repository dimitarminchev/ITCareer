/*
Задача 6.6. Депозитни суми за семейство Ollivander
Изберете всички депозитни групи и общата депозитна сума, но само за тези магьосници, чиято пръчка е измайсторена от семейство Ollivander. Сортирате резултатите по deposit_group в азбучен ред.
*/
USE `gringotts`;
SELECT `deposit_group`, 
       SUM(`deposit_amount`) AS `total_sum`
FROM `wizzard_deposits` AS `w`
WHERE `magic_wand_creator` = "Ollivander family"
GROUP BY `deposit_group`
ORDER BY `deposit_group` ASC;