/* 708. Банков превод */
USE bank;

-- Изтриване на съхранената процедура
DROP PROCEDURE IF EXISTS usp_transfer_money;

-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_transfer_money
                 (from_account_id INT, to_account_id INT, amount DECIMAL(15,4))
BEGIN
	-- Тяло на съхранената процедура
    START TRANSACTION;       
	UPDATE accounts SET balance = balance - amount WHERE id = from_account_id;   
    UPDATE accounts SET balance = balance + amount WHERE id = to_account_id;    
	IF (amount < 0) OR (from_account_id = to_account_id) OR
       (NOT EXISTS (SELECT id FROM accounts WHERE id = from_account_id)) OR
       (NOT EXISTS (SELECT id FROM accounts WHERE id = to_account_id)) OR
       ((SELECT balance FROM accounts WHERE id = from_account_id) < 0) THEN
        ROLLBACK;
	ELSE 
		COMMIT;   
	END IF;
END
$$	
			
-- Изпълнение на съхранената процедура
CALL usp_transfer_money(1,2,10);

-- Проверка на резултата
SELECT id AS account_id, AccountHolderId AS account_holder_id, balance 
FROM accounts
WHERE id IN (1,2);