/*
Задача 3.17. Увеличаване на заплати
Напишете SQL заявка за увеличаване на заплатите на всички служители, които са  в отделите Engineering, Tool Design, Marketing или Information Services с 12 %. След това изберете колоната със заплатите  от таблицата Emmployees. Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.).
*/
SELECT `department_id` as "id"
FROM `soft_uni`.`departments`
WHERE `name` IN ("Engineering", "Tool Design", "Marketing",  "Information Services");
/* Result: 1, 2, 4, 11 */

UPDATE `soft_uni`.`employees`
SET `salary` = `salary` * 1.12
WHERE `department_id` IN (1, 2, 4, 11);
/* Result: 28 affected rows*/