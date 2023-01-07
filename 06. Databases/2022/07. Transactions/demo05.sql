-- Procedure to sum two numbers
DELIMITER $$
CREATE PROCEDURE usp_add_numbers
(first_number INT, second_number INT, OUT result INT)
DETERMINISTIC
BEGIN
   SET result = first_number + second_number;
END 
$$

SET @answer=0;
CALL usp_add_numbers(5, 6,@answer);
SELECT @answer;

-- 11
