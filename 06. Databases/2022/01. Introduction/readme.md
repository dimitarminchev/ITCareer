# 1. Въведение
Базата данни е организирана колекция от информация, като налага правила на съдържащите се данни.
Системата за Управление на Релационна База от Данни (СУРДБ) предоставя инструменти за управление на база данни.
Релационно съхранение, първо предложено от Едгар Код през 1970 г.

## Инсталация
http://dev.mysql.com/downloads/windows/installer/
- MySQL Community Server
- MySQL Workbench

## Типове данни 
https://dev.mysql.com/doc/refman/5.5/en/storage-requirements.html

### Numeric
| Data Type                  | Storage Required                                  |
|----------------------------|---------------------------------------------------|
| TINYINT                    | 1 byte                                            |
| SMALLINT                   | 2 bytes                                           |
| MEDIUMINT                  | 3 bytes                                           |
| INT, INTEGER               | 4 bytes                                           |
| BIGINT                     | 8 bytes                                           |
| FLOAT(p)                   | 4 bytes if 0 <= p <= 24, 8 bytes if 25 <= p <= 53 |
| FLOAT                      | 4 bytes                                           |
| DOUBLE [PRECISION], REAL   | 8 bytes                                           |
| DECIMAL(M,D), NUMERIC(M,D) | Varies; see following discussion                  |
| BIT(M)                     | approximately (M+7)/8 bytes                       |

### Date and Time 
| Data Type | Storage Required |
|-----------|------------------|
| DATE      | 3 bytes          |
| TIME      | 3 bytes          |
| DATETIME  | 8 bytes          |
| TIMESTAMP | 4 bytes          |
| YEAR      | 1 byte           |

### String 

| Data Type | Storage |
| --- | --- |
| CHAR(M) | The compact family of InnoDB row formats optimize storage for variable-length character sets. See COMPACT Row Format Storage Characteristics. Otherwise, M × w bytes, <= M <= 255, where w is the number of bytes required for the maximum-length character in the character set. |
| BINARY(M)	M bytes | 0 <= M <= 255 |
| VARCHAR(M), VARBINARY(M) | L + 1 bytes if column values require 0 − 255 bytes | L + 2 bytes if values may require more than 255 bytes |
| TINYBLOB, TINYTEXT | L + 1 bytes, where L < 2^8 |
| BLOB, TEXT | L + 2 bytes, where L < 2^16 |
| MEDIUMBLOB, MEDIUMTEXT | L + 3 bytes, where L < 2^24 |
| LONGBLOB, LONGTEXT | L + 4 bytes, where L < 2^32 |            
| ENUM('value1','value2'...)  | 1 or 2 bytes  depending on the number of enumeration values (65,535 values maximum) |
| SET('value1','value2'...)	  | 1,2,3,4 or 8 bytes depending on the number of set members (64 members maximum) |

### Упражнение
```
/* Създаване на нова база данни */
CREATE SCHEMA minions;

/* Избор на база данни по подразбиране */
USE minions;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS minions
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
age INT NULL,
CONSTRAINT pk_minions PRIMARY KEY (id)
);

/* Извеждане на всички записи от таблица  */
SELECT * FROM minions;

/* Добавяне на нови записи в таблица */
INSERT INTO minions (name, age) VALUES ('Kevin', '15');
INSERT INTO minions (name, age) VALUES ('Bob', '22');
INSERT INTO minions (name) VALUES ('Steward');

/* Актуализация на запис от таблица */
UPDATE minions SET age=10 WHERE id=3;

/* Актуализация на всички записи от таблица */
UPDATE minions SET age=age+1;

/* Изтриване на запис от таблица */
DELETE FROM minions WHERE id=2;

/* Изтриване на всички записи от таблица */
DELETE FROM minions;

/* Изтриване на таблица */
DROP TABLE minions;

/* Изтриване на база данни */
DROP SCHEMA minions;
```
