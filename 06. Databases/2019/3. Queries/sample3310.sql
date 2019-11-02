/* 33.10 */
SELECT concat(first_name, ' ', last_name) AS "Full Name" 
FROM `soft_uni`.`employees` WHERE salary IN (25000, 14000, 12500);