/* Problem 2. Възрастови групи */
(
	SELECT "[0-10]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age <= 10
) UNION (
	SELECT "[11-20]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 10 AND age < 21
) UNION (
	SELECT "[21-30]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 20 AND age < 31
) UNION (
	SELECT "[31-40]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 30 AND age < 41
) UNION (
	SELECT "[41-50]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 40 AND age < 51
) UNION (
	SELECT "[51-60]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 50 AND age < 61
) UNION (
	SELECT "[61+]" AS `age_group`, COUNT(id) AS `wizard_count`
	FROM gringotts.wizzard_deposits
	WHERE age > 60
);

