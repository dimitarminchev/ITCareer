# 6. Агрегация и групиране на данни
- GROUP BY
- COUNT, SUM, MAX, MIN, AVG
- HAVING

### Групиране
С **GROUP BY** можете да извлечете всяка отделна група и да използвате "агрегираща" функция върху нея (AVG, MIN, MAX):

```sql
SELECT `e`.`department_id` 
FROM `employees` AS `e`
GROUP BY `e`.`department_id`;
```

С **DISTINCT** ще получите всички уникални стойности:
```sql
SELECT DISTINCT `e`.`department_id`
FROM `employees` AS `e`;
```

### Агрегации
Агрегиращите функции се използват, за да се извършват операции върху една или повече групи елементи, извършвайки анализ върху тях. 

**COUNT** брои всички стойности (които не са NULL) в една или повече колони, според даден критерий.
```sql
SELECT `e`.`department_id`, COUNT(`e`.`salary`) AS 'Salary Count'
FROM `employees` AS `e`
GROUP BY `e`.`department_id`;
```

**SUM** сумира всички стойности в колоната
```sql
SELECT `e`.`department_id`, SUM(`e`.`salary`) AS 'TotalSalary'
FROM `employees` AS `e`
GROUP BY `e`.`department_id`;
```

**MAX** дава максималната стойност в колоната.
```sql
SELECT e.`department_id`, MAX(`e`.`salary`) AS 'MaxSalary'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

**MIN** връща минималната стойност в колоната.
```sql
SELECT `e`.`department_id`, MIN(`e`.`salary`) AS 'MinSalary'
FROM `employees` AS `e`
GROUP BY `e`.`department_id`;
```

**AVG** изчислява средната стойност в колона.
```sql
SELECT `e`.`department_id`, AVG(`e`.`salary`) AS 'AvgSalary'
FROM `employees` AS `e`
GROUP BY `e`.`department_id`;
```

### Филтриране
Клаузата **HAVING** се използва, за да се филтрира информация според стойностите от агрегирането. Това значи, че не можем да използваме HAVING без да сме извършили групиране преди това. За разлика от HAVING, WHERE извършва филтриране преди да се случи агрегирането.

```sql
SELECT `e`.`department_id`,  SUM(`e`.`salary`) AS 'TotalSalary'
FROM `employees` AS `e`
GROUP BY `e`.`department_id`
HAVING `TotalSalary` < 250000;
```
