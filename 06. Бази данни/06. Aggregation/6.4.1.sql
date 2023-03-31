/* Задача 6.8. Минимално зареждане на депозит */
USE `gringotts`;
SELECT `deposit_group`, `magic_wand_creator`,
		 min(`deposit_charge`) AS `min_deposit_charge`
FROM `wizzard_deposits`
GROUP BY `deposit_group`
ORDER BY `magic_wand_creator`, `deposit_group`;

