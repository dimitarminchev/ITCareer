/* Избор на база данни по подразбиране */
USE minions;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS users
(
id BIGINT NOT NULL AUTO_INCREMENT,
username VARCHAR(30) NOT NULL,
password VARCHAR(26) NOT NULL,
profile_picture BLOB,
last_login_time DATETIME,
is_deleted INT,
CONSTRAINT pk_users PRIMARY KEY (id)
);

/* Добавяне на нови записи в таблица */
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('pesho', '123456', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('gosho', '234567', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('mitko', '345678', NULL, NOW(), 1);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('cecko', '456789', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('bosko', '5678910', NULL, NOW(), 1);

/* Извеждане на броя записи от таблица  */
SELECT COUNT(*) FROM users;

/* Актуализация на първичния ключ */
ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id, username);

/* Задаване на стойност по подразбиране на поле */
ALTER TABLE users
	CHANGE COLUMN last_login_time last_login_time DATETIME NULL DEFAULT CURRENT_TIMESTAMP;

/* Задаване на изискване за уникалност на поле от таблицата */
ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id),
	ADD CONSTRAINT uc_username UNIQUE (username);
