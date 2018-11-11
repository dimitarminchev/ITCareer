/* 707. Изтегляне на пари */
USE bank;

-- Изтриване на съхранената процедура
DROP PROCEDURE IF EXISTS usp_withdraw_money;

-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_withdraw_money (account_id INT, money_amount DECIMAL(14,2))
BEGIN
	-- Тяло на съхранената процедура
	START TRANSACTION;      
	UPDATE accounts SET balance = balance- money_amount WHERE id = account_id;    
	IF (money_amount < 0) OR ((SELECT balance FROM accounts WHERE id = account_id) < 0) THEN
        ROLLBACK;
	ELSE 
		COMMIT;   
	END IF;
END
$$
-- Извикване и изпълнение на съхранената процедура
CALL usp_withdraw_money(1,10);
-- Проверка на баланса
SELECT balance FROM accounts WHERE id = 1;