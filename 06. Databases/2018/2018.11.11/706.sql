/* 706. Дефинирайте функция */
USE company;

-- Изтриване на функцията 
DROP FUNCTION IF EXISTS ufn_is_word_comprised;

-- Създаване на функция
DELIMITER $$
CREATE FUNCTION ufn_is_word_comprised(set_of_letters TEXT, word TEXT)
RETURNS BOOLEAN
DETERMINISTIC
BEGIN
	-- Тяло на функцията
    DECLARE pos INT DEFAULT 1;
    DECLARE letter CHAR(1);
    WHILE (pos <= LENGTH(word)) DO
      SET letter := SUBSTR(word,pos,1); 
      IF (LOCATE(letter,set_of_letters) <= 0) THEN
        RETURN FALSE;
      END IF;
      SET pos := pos + 1;
    END WHILE;
    RETURN TRUE;
END 
$$

-- Създаване на таблица
DROP TABLE IF EXISTS table706;
CREATE TABLE IF NOT EXISTS table706 
(
	set_of_letters TEXT, 
	word TEXT
);
INSERT INTO table706 VALUES 
("Oistmiahf","Sofia"),("Oistmiahf","halves"),("Bobr","Rob"),("Pppp","Guy"); 

-- Използване на функцията
SELECT set_of_letters, word, ufn_is_word_comprised(set_of_letters,word) AS result 
FROM table706;