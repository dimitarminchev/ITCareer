/* 3.3.21 */
SELECT `country_name`,`country_code`, 
IF(`currency_code` = "EUR", "Euro" , "Not Euro") as "Currency"
FROM `geography`.`countries`
ORDER BY `country_name`;