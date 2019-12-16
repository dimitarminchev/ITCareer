
DELIMITER $$  
CREATE FUNCTION ufn_is_word_comprised(set_of_letters TEXT, word TEXT)
RETURNS TEXT
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
