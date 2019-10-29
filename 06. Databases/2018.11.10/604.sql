/* 604. Smallest Deposit Group per Magic Wand Size */
USE gringotts;

DROP TABLE IF EXISTS table604;

CREATE TABLE IF NOT EXISTS table604 AS 
(
	SELECT deposit_group,AVG(magic_wand_size) as `AVR`
	FROM wizzard_deposits
	GROUP BY deposit_group
);

SELECT deposit_group 
FROM table604
WHERE `AVR` = 
(
	SELECT MIN(`AVR`) AS `MIN` FROM table604
);