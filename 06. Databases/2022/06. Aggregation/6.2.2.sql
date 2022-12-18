/* 6.2.2. Най-малката депозитна група с най-малката магическа пръчка */
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
