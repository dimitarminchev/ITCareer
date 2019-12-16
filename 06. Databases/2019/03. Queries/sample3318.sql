SELECT salary FROM soft_uni.employees WHERE department_id IN
(
  SELECT department_id FROM departments WHERE `name` IN("Engineering","Tool Design","Information Services")
);

UPDATE soft_uni.employees 
SET salary= salary*1.12 
WHERE department_id IN
(
  SELECT department_id FROM departments WHERE `name` IN("Engineering","Tool Design","Information Services")
);

SELECT salary FROM soft_uni.employees WHERE department_id IN
(
  SELECT department_id FROM departments WHERE `name` IN("Engineering","Tool Design","Information Services")
);