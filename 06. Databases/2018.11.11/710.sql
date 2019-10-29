/* 710. Тригер за мейли */
USE bank;

-- Изтриване на таблица
DROP TABLE IF EXISTS `notification_emails`;

-- Създаване на таблица
CREATE TABLE `notification_emails` 
(
	id INT(11) NOT NULL AUTO_INCREMENT, 
    `recipient` INT(11), 
    `subject` TEXT,  
    `body` TEXT,
    PRIMARY KEY (id)
);

-- Изтриване на тригер
DROP TRIGGER IF EXISTS triger_insert_logs;

-- Добавяне на тригер
DELIMITER $$
CREATE TRIGGER triger_insert_logs
AFTER INSERT
ON `logs`
FOR EACH ROW
BEGIN    
	INSERT INTO `notification_emails` (`recipient`, `subject`, `body`)
	VALUES 
    (
		new.account_id, 		
        (
			SELECT CONCAT("Balance change for account: {",old_sum,"}") AS `subject`
            FROM `logs` 
            WHERE account_id = new.account_id
            ORDER BY account_id DESC 
            LIMIT 1
		),        
        (
			SELECT CONCAT("On {",NOW(),"} your balance was changed from {",old_sum,"} to {",new_sum,"}") AS `body` 
            FROM `logs` 
            WHERE account_id = new.account_id
            ORDER BY account_id DESC 
            LIMIT 1
		) 
	);
END 
$$