/* 1. Създаване на таблица */
CREATE TABLE minions (id INT, name VARCHAR(50), age INT);

/* 2. Добавяне на записи в таблицата */
INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');
INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22')
INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42')

/* 3. Извеждане на записите от таблицата */
SELECT name,age FROM minions;
