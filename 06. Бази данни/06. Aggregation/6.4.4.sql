/*
Задача 6.11. Средна лихва 
Господин Бодрог много се интересува от доходността. Той иска да знае средната лихва на всички депозитни групи разделени според това дали депозита е изтекъл или не. Но това не е всичко. Той иска да изберете депозитите със стартова дата след 01/01/1985. Подредете информацията в намаляващ ред по депозитна група и в нарастващ ред по изтичане.
*/
USE `gringotts`;
SELECT `deposit_group`,	`is_deposit_expired`, 
AVG(`deposit_interest`) AS `average_interest`
FROM `wizzard_deposits`
WHERE `deposit_start_date` >= 01/01/1985
GROUP BY `deposit_group`, `is_deposit_expired`
ORDER BY `deposit_group` DESC, `is_deposit_expired` ASC;
