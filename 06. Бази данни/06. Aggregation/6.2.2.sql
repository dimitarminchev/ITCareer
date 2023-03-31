/* 
Задача 6.4. Най-малката депозитна група с най-малката магическа пръчка
Изберете депозитната група, с най-малката средноаритметична стойност от размера на пръчките си.
*/
USE `gringotts`;
SELECT `avg`.`deposit_group`
FROM
(
	SELECT `deposit_group`, AVG(`magic_wand_size`) AS `avg_magic_wand`
	FROM `wizzard_deposits` AS `w`
	GROUP BY `deposit_group`
	ORDER BY `avg_magic_wand` ASC
	LIMIT 1
) AS `avg`;
