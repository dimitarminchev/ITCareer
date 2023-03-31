/*
Задача 6.5. Сума от депозити
Изберете всички депозитни групи и тяхната обща депозитна сума. Сортирайте резултатите по total_sum в нарастващ ред.
*/
USE `gringotts`;
SELECT `deposit_group`, 
       SUM(`deposit_amount`) AS `total_sum`
FROM `wizzard_deposits`
GROUP BY `deposit_group`
ORDER BY `total_sum` ASC;
