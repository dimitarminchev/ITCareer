/* database movies */
CREATE DATABASE IF NOT EXISTS `movies`;
USE `movies`;

CREATE TABLE IF NOT EXISTS `directors` 
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `director_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_directors` PRIMARY KEY (`id`)
);

INSERT INTO `directors` (`director_name`) VALUES ("Steven King");
INSERT INTO `directors` (`director_name`) VALUES ("Steven Spelberg");
INSERT INTO `directors` (`director_name`) VALUES ("Steven Segal");
INSERT INTO `directors` (`director_name`) VALUES ("Steven Hawkins");

CREATE TABLE IF NOT EXISTS `genres` 
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `genre_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_genres` PRIMARY KEY (`id`)
);

INSERT INTO `genres` (`genre_name`) VALUES ("comedy");
INSERT INTO `genres` (`genre_name`) VALUES ("tragedy");
INSERT INTO `genres` (`genre_name`) VALUES ("drama");
INSERT INTO `genres` (`genre_name`) VALUES ("horror");
INSERT INTO `genres` (`genre_name`) VALUES ("science - fiction");

CREATE TABLE IF NOT EXISTS `categories`
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `category_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_categories` PRIMARY KEY (`id`)
);

INSERT INTO `categories` (`category_name`) VALUES ("16+");
INSERT INTO `categories` (`category_name`) VALUES ("18+");
INSERT INTO `categories` (`category_name`) VALUES ("21+");

CREATE TABLE IF NOT EXISTS `movies`
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `title` TEXT NULL, 
    `director_id` INT NOT NULL, 
    `copyright_year` DATE NULL, 
    `length` TIME NULL, 
	`genre_id` INT NOT NULL, 
    `category_id` INT NOT NULL, 
    `rating` INT(1) DEFAULT 0, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_movies` PRIMARY KEY (`id`),
    CONSTRAINT `fk_director` FOREIGN KEY (`director_id`) REFERENCES `directors`(`id`),
    CONSTRAINT `fk_genre` FOREIGN KEY (`genre_id`) REFERENCES `genres`(`id`),
    CONSTRAINT `fk_category` FOREIGN KEY (`category_id`) REFERENCES `categories`(`id`)
);

INSERT INTO `movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('Game of nerves', '4','1982-01-01','01:20','1','3','5');
 INSERT INTO `movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('Star Wars', '2','1985-02-03','02:10','5','1','5');
 INSERT INTO `movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('2 men and 1/2', '3','2009-04-05','00:47','3','1','4');