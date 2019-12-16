/* Problem 4.	Средна лихва  */
SELECT deposit_group, is_deposit_expired,  AVG(deposit_interest) AS `average_interest`
FROM gringotts.wizzard_deposits
WHERE deposit_expiration_date >= "1985-01-01" 
GROUP BY deposit_group
ORDER BY deposit_group DESC, deposit_expiration_date ASC;