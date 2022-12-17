# 5. Съединения на таблици 
```sql
JOIN
INNER JOIN
OUTER JOIN (LEFT and RIGHT)
FULL JOIN (LEFT JOIN UNION RIGHT JOIN) and CROSS JOIN
```

## 5.1. JOIN

### Декартово произведение
Декартово произведение получаваме, когато JOIN условието липсва или е невалидно.
```sql
USE `soft_uni`;
SELECT concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees`, `departments`;
```
293 employee x 16 departmens = 4688

### Връзки между таблици 
Релациите между таблици са полезни, когато са съчетани с връзки **JOIN**. Така можем да извлечем данни едновременно от две таблици.
```sql
USE `soft_uni`;
SELECT  concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees` 
JOIN `departments` ON `departments`.`department_id` = `employees`.`department_id`;
```
**Бележка**: връзките с JOIN са по-производителни от вложените SELECT

### Задача: Върхове в Рила
Използвайте базата данни **Geography**. Изведете справка за всички върхове в планината **Rila**.
Справката да включва имената на планината, на върха и височината на върха.
Върховете да са сортирани по височина, в намаляващ ред.
```sql
USE `geography`;
SELECT m.`mountain_range`, p.`peak_name`, p.`elevation`
FROM `mountains` AS m
JOIN `peaks` AS p ON p.`mountain_id` = m.`id`
WHERE m.`mountain_range` = "Rila"
ORDER BY p.`elevation` DESC;
```

## 5.2. INNER JOIN
Ако се използва само **JOIN**, се подразбира **INNER JOIN**.

### Задача: Адреси с градове
Покажете информация за адреса на всички служители в базата данни **SoftUni**. Изберете първите 5 служителя. Подредете ги по **first_name**, после по **last_name** (възходящо). Съвет:  Използвайте връзка (**JOIN**) между три таблици.
```sql
SELECT `e`.`first_name`, `e`.`last_name`, `t`.`name` as `town`, `a`.`address_text`
FROM `employees` AS `e`
JOIN `addresses` AS `a` ON `e`.`address_id` = `a`.`address_id`
JOIN `towns` AS `t` ON `a`.`town_id` = `t`.`town_id`
ORDER BY `e`.`first_name`, `e`.`last_name` 
LIMIT 5;
```

### Задача: Служители по продажбите
Намерете всички служители, които са в отдел **Sales**. Използвайте базата данни **SoftUni**.
Следвайте специфичния формат. Подредете ги по employee_id низходящо.
```sql
SELECT `e`.`employee_id`, `e`.`first_name`, `e`.`last_name`, `d`.`name` AS `department_name`
FROM `employees` AS `e` 
INNER JOIN `departments` AS `d` ON `e`.`department_id` = `d`.`department_id`
WHERE `d`.`name` = 'Sales'
ORDER BY `e`.`employee_id` DESC;
```

### Задача: Служители наети след дата
Покажете всички служители, които:
- Са наети след **1/1/1999**.
- Са в някой от отделите **Sales** или **Finance**.
- Сортирайте по **hire_date** (възходящо).
```sql
SELECT `e`.`first_name`, `e`.`last_name`, `e`.`hire_date`, `d`.`name`
FROM `employees` AS `e`
INNER JOIN `departments` AS `d` ON (`e`.`department_id` = `d`.`department_id` AND DATE(`e`.`hire_date`) > '1999/1/1' AND `d`.`name` IN ('Sales', 'Finance'))
ORDER BY `e`.`hire_date`;
```

## 5.3. OUTER JOIN 
### LEFT OUTER JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от лявата таблица.
```sql
SELECT * FROM `employees` AS `e`
LEFT OUTER JOIN `departments` AS `d` ON `e`.`department_id` = `d`.`department_id`;
```

### RIGHT OUTER JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от дясната таблица.
```sql
SELECT * FROM `employees` AS `e`
RIGHT OUTER JOIN `departments` AS `d` ON `e`.`department_id` = `d`.`department_id`;
```

### Задача: Страни, в които няма планини
Изведете броя на страните, в които няма планини.
Използвайте базата данни **Geography**.
```sql
SELECT  COUNT(*) AS `country_count`  
FROM  `countries` AS `c`
LEFT JOIN `mountains_countries` AS `mc` ON `c`.`country_code` = `mc`.`country_code`
WHERE `mc`.`mountain_id` IS NULL;
```

## 5.4. FULL JOIN AND CROSS JOIN
- FULL JOIN обединява LEFT JOIN и RIGHT JOIN.
- CROSS JOIN комбинира всеки ред от първата таблица с всеки ред от втората.

### FULL JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от лявата и от дясната таблица.
```sql
(
  SELECT * FROM `employees` AS `e`
  LEFT OUTER JOIN `departments` AS `d` ON `e`.`department_id`=`d`.`department_id`
)
UNION
(
  SELECT * FROM `employees` AS `e`
  RIGHT OUTER JOIN `departments` AS `d` ON `e`.`department_id`=`d`.`department_id`
);
```

### CROSS JOIN
При тази връзка всеки ред от първата таблица е комбиниран с всеки ред от втората.
```sql
SELECT * FROM `employees` AS `e`
CROSS JOIN `departments` AS `d`;
```
