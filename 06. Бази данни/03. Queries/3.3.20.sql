/*
Задача 3.20. Страни и валута (Euro / Not Euro)
Намерете всички страни заедно с информация за своята валута. Покажете  името на страната, код на страната и информация за валутата ѝ: "Euro" или "Not euro". Сортирайте резултатите по име на страната по азбучен ред.  . Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.).
*/
SELECT `country_name`,`country_code`, 
IF(`currency_code` = "EUR", "Euro" , "Not Euro") as "Currency"
FROM `geography`.`countries`
ORDER BY `country_name`;