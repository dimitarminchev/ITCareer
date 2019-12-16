DELIMITER $$

CREATE PROCEDURE udp_update_salary()
BEGIN
  
    -- Transaction
	START TRANSACTION;

	-- Trying to update multiple records
	UPDATE soft_uni.employees 
	SET soft_uni.employees.salary = soft_uni.employees.salary * 2
	WHERE  employee_id IN (3,5,7);

	-- Affected rows are different than one?
	IF ROW_COUNT() <> 1 THEN 
		-- Error 
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error';
		ROLLBACK;
	ELSE 
		-- Executing       
        SIGNAL SQLSTATE '01000' SET MESSAGE_TEXT = 'Done';
		COMMIT;
	END IF;
END
$$

-- Check
SELECT employee_id,salary FROM soft_uni.employees WHERE employee_id IN (3,5,7);
