/* Задача 5.22. *Континенти и валути */
USE `geography`;

SELECT `usages`.`continent_code`, `usages`.`currency_code`, `usages`.`usages` FROM
(
	SELECT `con`.`continent_code`, `cu`.`currency_code`, COUNT(`cu`.`currency_code`) AS `usages` 
	FROM `continents` AS `con`
	INNER JOIN `countries` AS `c` ON `c`.`continent_code` = `con`.`continent_code`
	INNER JOIN `currencies` AS `cu` ON `cu`.`currency_code` = `c`.`currency_code`
	GROUP BY `con`.`continent_code`, `cu`.`currency_code`
) AS `usages`
INNER JOIN
(
	SELECT `usages`.`continent_code`, MAX(`usages`.`usages`) AS `maxUsage`
	FROM 
	(
		SELECT `con`.`continent_code`, `cu`.`currency_code`, COUNT(`cu`.`currency_code`) AS `usages` 
		FROM `continents` AS `con`
		INNER JOIN `countries` AS `c` ON `c`.`continent_code` = `con`.`continent_code`
		INNER JOIN `currencies` AS `cu` ON `cu`.`currency_code` = `c`.`currency_code`
		GROUP BY `con`.`continent_code`, `cu`.`currency_code`
		HAVING COUNT(`cu`.`currency_code`) > 1
	) as `usages`
	GROUP BY `usages`.`continent_code`
) AS `max_usages` 
ON `max_usages`.`continent_code` = `usages`.`continent_code` AND `max_usages`.`maxUsage` = `usages`.`usages`

ORDER BY `usages`.`continent_code`, `usages`.`currency_code`;