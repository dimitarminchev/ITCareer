/* 4.2. Върхове на планини в българия */
SELECT `peak_name`, `elevation` 
FROM `geography`.`peaks`
WHERE `mountain_id` IN 
(
	SELECT `mountain_id` FROM `mountains_countries`
    WHERE `country_code` = "BG"
)
ORDER BY `elevation` DESC