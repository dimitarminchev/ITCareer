/*
Задача 3.16. Последните 7 наети служители
Напишете SQL заявка, която намира последните 7 наети служители. Изберете техните собствени имена, фамилни имена и датата им на наемане. Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.).
*/
SELECT `first_name`,`last_name`,`hire_date`
FROM `soft_uni`.`employees`
ORDER BY `hire_date` DESC
LIMIT 7;