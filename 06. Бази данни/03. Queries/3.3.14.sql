/*
Задача 3.14. Различни длъжности
Напишете SQL заявка,която  намира всички различни длъжности. Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.)
*/
SELECT DISTINCT `job_title`
FROM `soft_uni`.`employees`
ORDER BY `job_title`;