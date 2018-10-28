/* 222. One to Many Relationship */

CREATE SCHEMA db222;
USE db222;

CREATE TABLE manufacturers(
	manufacturer_id INT AUTO_INCREMENT NOT NULL,
    name VARCHAR(20) NOT NULL,
    established_on DATE NULL,
    PRIMARY KEY(manufacturer_id)
);

CREATE TABLE models(
	model_id INT AUTO_INCREMENT NOT NULL,
    name VARCHAR(20) NOT NULL,
    manufacturer_id INT NOT NULL,
    PRIMARY KEY(model_id),
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturers(manufacturer_id) 
)AUTO_INCREMENT = 101;

INSERT INTO manufacturers(name, established_on)
VALUES
('BMW', '1916-03-01'),
('Tesla', '2003-01-01'),
('Lada', '1966-05-01');

INSERT INTO models(name, manufacturer_id)
VALUES
('X1',1),
('i6',1),
('Model S',2),
('Model X2',2),
('Model 3',2),
('Nova',3);