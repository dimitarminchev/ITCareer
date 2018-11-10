/* 612. Rich Wizard, Poor Wizard */
USE gringotts;

SELECT SUM(de.difference) AS sum_difference
FROM 
(
	SELECT wd1.first_name AS host_wizard,
       wd1.deposit_amount AS host_wizard_deposit,
       wd2.first_name AS guest_wizard,
       wd2.deposit_amount AS guest_wizard_deposit,
       (wd1.deposit_amount - wd2.deposit_amount) AS difference
	FROM wizzard_deposits wd1
    JOIN wizzard_deposits wd2 ON wd1.id = (wd2.id - 1)
) AS de
