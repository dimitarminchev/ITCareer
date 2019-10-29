/* Създаване на нова база данни */
CREATE SCHEMA movies;

/* Избор на база данни по подразбиране */
USE movies;

/* Създаване на нови таблици */
CREATE TABLE IF NOT EXISTS directors
(
id INT NOT NULL AUTO_INCREMENT,
director_name VARCHAR(50) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_directors PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS genres
(
id INT NOT NULL AUTO_INCREMENT,
genre_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_genres PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS categories
(
id INT NOT NULL AUTO_INCREMENT,
category_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_categories PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS movies
(
id INT NOT NULL AUTO_INCREMENT,
title VARCHAR(50) NOT NULL,
director_id INT NOT NULL,
copyright_year SMALLINT,
length INT,
genre_id INT,
category_id INT,
rating FLOAT,
notes VARCHAR(1000),
CONSTRAINT pk_movies PRIMARY KEY (id)
);

/* Добавяне на нови записи в таблица */
INSERT INTO directors (director_name, notes) VALUES ('Ben Affleck', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Woody Allen', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Luc Besson', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Cameron Crowe', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Clint Eastwood', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Action', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Comedy', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Horror', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Thriller', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Drama', 'sample notes');
INSERT INTO categories (category_name, notes) VALUES ('0-3', 'suitable for infants');
INSERT INTO categories (category_name, notes) VALUES ('7-12', 'suitable for kids');
INSERT INTO categories (category_name, notes) VALUES ('12-16', 'suitable for teenagers');
INSERT INTO categories (category_name, notes) VALUES ('16-18', NULL);
INSERT INTO categories (category_name, notes) VALUES ('18+', 'suitable for adults');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Titanic', 1, 1998, 181, 1, 4, 8.2, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Avatar', 4, 2008, 160, 2, 3, 9.22, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 1', 2, 1980, 90, 3, 1, 9.99, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 2', 3, 1983, 92, 5, 2, 10.1, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 3', 1, 1986, 95, 1, 5, 6.2, 'sample notes');

/* Извеждане на броя записи в таблиците  */
SELECT COUNT(*) FROM directors;
SELECT COUNT(*) FROM genres;
SELECT COUNT(*) FROM categories;
SELECT COUNT(*) FROM movies;
