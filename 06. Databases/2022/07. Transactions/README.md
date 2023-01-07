# 7. Скаларни функции, работа с дати, транзакции
- CREATE PROCEDURE
- CREATE FUNCTION
- START TRANSACTION + ROLLBACK + COMMIT
- CREATE TRIGGER (BEFORE|AFTER + INSERT|UPDATE|DELETE)

### 7.1. Функции
- Винаги връщат стойност
- Могат да приемат параметри
- Могат да са вложени

**Деклариране на функция
```sql
DELIMITER $$
CREATE FUNCTION udf_project_weeks (start_date DATETIME, end_date DATETIME)
RETURNS INT
BEGIN
	DECLARE project_weeks INT;
	IF(end_date IS NULL) THEN
		SET end_date := NOW();	
	END IF;
	SET project_weeks := DATEDIFF(DATE(end_date), DATE(start_date)) / 7;
	RETURN project_weeks;
END $$
```

**Изпълнение на функция**
```sql
SELECT p.project_id, 
	DATE(p.start_date) AS 'start_date', 
	DATE(p.end_date) AS 'end_date',
	udf_project_weeks(p.start_date, p.end_date) AS 'project_weeks'
FROM projects AS p;
```

### 7.2. Транзакции
Транзакцията е поредица от действия (операции в базата данни) изпълнявани като цялост или всички се изпълняват заедно успешно или нито едно от тях не се изпълнява.

Транзакциите гарантират пълнотата и цялостността на базата данни.
- Всички промени в транзакцията са временни.
- Промените се съхраняват едва след изпълнението на **COMMIT**.
- По всяко време всички промени могат да се отменят чрез **ROLLBACK**.
- Всички операции се изпълняват като едно цяло.

```sql
START TRANSACTION
UPDATE accounts SET balance = balance – withdraw_amount
WHERE id = account
IF ROW_COUNT() <> 1 THEN -- Affected rows are different than one.
	SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid account';
	ROLLBACK;
ELSE 
	COMMIT;
END IF;
```

### 7.3. Съхранени процедури
Съхранените процедури:
- Капсулират повтаряща се програмна логика.
- Могат да приемат входни параметри.
- Могат да връщат изходни резултати.

**Създаване на съхранена процедура**
```sql
DELIMITER $$
CREATE PROCEDURE usp_select_employees_by_seniority() 
BEGIN
  SELECT * 
  FROM employees
  WHERE ROUND((DATEDIFF(NOW(), hire_date) / 365.25)) < 15;
END $$
```

**Изпълняване на съхранени процедури**
```sql
CALL usp_select_employees_by_seniority();
```

**Изтриване на съхранени процедури**
```sql
DROP PROCEDURE usp_select_employees_by_seniority;
```

**Дефиниране на параметризирани процедури**
```sql
DELIMITER $$
CREATE PROCEDURE usp_select_employees_by_seniority(min_years_at_work INT)
BEGIN
  SELECT first_name, last_name, hire_date,
    ROUND(DATEDIFF(NOW(),DATE(hire_date)) / 365.25,0) AS 'years'
  FROM employees
  WHERE ROUND(DATEDIFF(NOW(),DATE(hire_date)) / 365.25,0) > min_years_at_work
  ORDER BY hire_date;
END $$

CALL usp_select_employees_by_seniority(15);
```

**Връщане на стойности**
```sql
CREATE PROCEDURE usp_add_numbers
(first_number INT,
second_number INT,
   OUT result INT)
BEGIN
   SET result = first_number + second_number
END $$
DELIMITER ;

SET @answer=0;
CALL usp_add_numbers(5, 6,@answer);
SELECT @answer;

-- 11
```

### 7.4. Тригери
Тригерите много приличат на съхранените процедури.
Извикват се в случай на дадено събитие.
Не извикваме тригерите изрично.
- Тригерите се прикрепят към таблицата.
- Тригерите се изпълняват, когато определена SQL заявка се изпълнява върху съдържанието на таблицата.
- Например при добавяне на нов ред в таблицата.

```sql
DELIMITER $$
CREATE TRIGGER tr_delete_records
AFTER DELETE
ON employees_projects
FOR EACH ROW
BEGIN
	INSERT INTO employees_projects_history
	      (employee_id, project_id)
	VALUES(old.employee_id, old.project_id);
END $$
```