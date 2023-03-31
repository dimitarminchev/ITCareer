/*
Задача 6.3. Най-дългата магическа пръчка по депозитна група
Покажете дължината на най-дългата магическа пръчка за всяка от депозитните групи. Сортирайте резултатите по най-дълга магическа пръчка за всяка депозитна група в нарастващ ред, а след това и по deposit_group в азбучен ред. Именувайте новата колона по подходящ начин.
*/
USE `gringotts`;
SELECT `deposit_group`, MAX(`magic_wand_size`) AS `longest_magic_wand`
FROM `wizzard_deposits` AS `w`
GROUP BY `deposit_group`
ORDER BY `deposit_group`;