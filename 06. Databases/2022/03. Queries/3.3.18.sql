/* 3.3.18 */
SELECT `department_id` as "id"
FROM `soft_uni`.`departments`
WHERE `name` IN ("Engineering", "Tool Design", "Marketing",  "Information Services");
/* Result: 1, 2, 4, 11 */

UPDATE `soft_uni`.`employees`
SET `salary` = `salary` * 1.12
WHERE `department_id` IN (1, 2, 4, 11);
/* Result: 28 affected rows*/