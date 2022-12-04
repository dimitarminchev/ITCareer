/* 3.3.20 */
SELECT `country_name`,`population`
FROM `geography`.`countries`
WHERE `continent_code`="EU"
ORDER BY `population` DESC
LIMIT 30;