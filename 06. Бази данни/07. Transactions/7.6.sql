
/*
Задача 7.6. Дефинирайте функция
Дефинирайте функция ufn_is_word_comprised(set_of_letters, word), която връща true или false според това дали думата е съставена от даденото множество от букви. 
*/
DELIMITER $$  
CREATE FUNCTION ufn_is_word_comprised(set_of_letters TEXT, word TEXT)
RETURNS TEXT
DETERMINISTIC
BEGIN
      DECLARE a INT Default 0 ;
      simple_loop: LOOP
         SET a=a+1;
         IF (LOCATE(LOWER(SUBSTRING(`word`,a,1)),LOWER(set_of_letters)) <= 0) THEN
         RETURN FALSE;
         END IF;
         IF a=length(word)-1 THEN
            LEAVE simple_loop;
         END IF;
   END LOOP simple_loop;
   RETURN TRUE;
END $$
