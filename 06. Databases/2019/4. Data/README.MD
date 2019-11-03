# 4. Сложни заявки за извличане на данни

## Форматиране на заявки

### Псевдоними на колони и таблици 
Псевдонимите служат за именуване на колони и таблици
```
SELECT c.duration, c.acg AS 'Access Control Gateway' FROM calls AS c;
```

### Сортиране на резултата 
Клаузата **ORDER BY** се ползва за подреждане (сортира) на редовете, във възходящ **ASC** (по подразбиране) или в низходящ **DESC** ред.
```
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` ASC;
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` DESC;
```

### Ограничаване на броя записи 
Клаузата **LIMIT** ни помага да ограничим броя на извежданите записи.
```
-- Извежда данни за най-високия връх на планетата
SELECT * FROM `geography`.`peaks` ORDER BY `elevation` DESC LIMIT 1;

-- Извличане на третия от най-старите служители
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` LIMIT 2, 1;
```

## Подзаявки
Заявките могат да бъдат вложени една в друга
```
SELECT * FROM employees WHERE department_id IN 
(
   SELECT department_id FROM departments WHERE name = 'Finance'
);
```

**SELECT** изразите може да бъдат влагани в **WHERE** клаузата
```
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = (SELECT Salary FROM Employees ORDER BY Salary DESC LIMIT 1)
```

### Всички върхове в България
Покажете списък с имената на всички върхове в България
- Намерете планините в България
- После покажете върховете от тези планини
- Сортирайте резултата по височина, в намаляващ ред 
```
SELECT peak_name, elevation FROM peaks WHERE mountain_id IN
(
    SELECT mountain_id 
    FROM mountains_countries   
    WHERE country_code = 'BG'
)
ORDER BY elevation DESC;
```

### Оператори ALL, ANY и SOME
- **ALL** = дали условието е в сила за всички стойности
- **ANY** = дали условието е в сила за поне една от стойностите
- **SOME** = синоним на ANY
```
SELECT FirstName, LastName, DepartmentID, Salary FROM Employees
WHERE DepartmentID = ANY (SELECT DepartmentID FROM Departments WHERE Name='Sales')
```
Таблична подзаявка
```
SELECT FirstName, LastName, DepartmentID, Salary FROM Employees
WHERE (DepartmentID, ManagerID) = ANY 
(SELECT DepartmentID, ManagerID FROM Departments WHERE Name='Sales')
```