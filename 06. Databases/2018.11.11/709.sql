/* 709. Логове за банкови сметки */
USE bank;

-- Изтриване на таблица
DROP TABLE IF EXISTS `logs`;

-- Създаване на таблица
CREATE TABLE `logs` 
(
	log_id INT(11) NOT NULL AUTO_INCREMENT, 
    account_id INT(11), 
    old_sum DECIMAL(15,4),  
    new_sum DECIMAL (15,4),
    PRIMARY KEY (log_id)
);

-- Изтриване на тригер
DROP TRIGGER IF EXISTS triger_update_accounts;

-- Добавяне на тригер
DELIMITER $$
CREATE TRIGGER triger_update_accounts
AFTER UPDATE
ON accounts
FOR EACH ROW
BEGIN
	INSERT INTO `logs` (account_id, old_sum, new_sum)
	VALUES (new.Id, old.Balance, new.Balance);
END 
$$
