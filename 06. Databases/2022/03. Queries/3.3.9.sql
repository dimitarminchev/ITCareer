/* 3.3.9 */
SELECT `first_name`,`last_name`,`job_title` AS "JobTitle"
FROM `soft_uni`.`employees`
WHERE `salary` BETWEEN 20000 AND 30000;