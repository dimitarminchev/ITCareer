

DELIMITER $$
CREATE PROCEDURE usp_get_towns_starting_with (start_letter TEXT)
BEGIN
	SELECT 	`name`
    FROM towns 
    WHERE LOWER(SUBSTRING(`name`,1, LENGTH(start_letter)))=LOWER(start_letter);
END
$$

