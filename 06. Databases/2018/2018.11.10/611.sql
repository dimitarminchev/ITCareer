/* 611. Average Interest  */
USE gringotts;

SELECT deposit_group,
       is_deposit_expired,
       AVG(deposit_interest) AS average_interest
FROM wizzard_deposits
WHERE deposit_start_date >= 01/01/1985
GROUP BY deposit_group, is_deposit_expired
ORDER BY deposit_group DESC, is_deposit_expired ASC; 