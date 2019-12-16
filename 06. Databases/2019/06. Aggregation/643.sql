/* Problem 3.	Първа буква */
SELECT DISTINCT LEFT(first_name,1) As `Letter`
FROM gringotts.wizzard_deposits
WHERE deposit_group = "Troll Chest"
ORDER BY `Letter`;
