-- 200. Създаване на БД

DROP SCHEMA IF EXISTS colonial_journey_management_system_db;
CREATE SCHEMA IF NOT EXISTS colonial_journey_management_system_db;
USE colonial_journey_management_system_db;

CREATE TABLE IF NOT EXISTS planets(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS spaceports(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    planet_id INT(11),
    FOREIGN KEY(planet_id) REFERENCES planets(id)
);

CREATE TABLE IF NOT EXISTS spaceships(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    manufacturer VARCHAR(30) NOT NULL,
    light_speed_rate INT(11) DEFAULT 0
);

CREATE TABLE IF NOT EXISTS colonists(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    ucn CHAR(10) NOT NULL UNIQUE,
    birth_date DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS journeys(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    journey_start DATETIME NOT NULL,
    journey_end DATETIME NOT NULL,
    purpose ENUM('Medical', 'Technical', 'Educational', 'Military'),
    destination_spaceport_id INT(11),
    spaceship_id INT(11),
    FOREIGN KEY(destination_spaceport_id) REFERENCES spaceports(id),
    FOREIGN KEY(spaceship_id) REFERENCES spaceships(id)
);

CREATE TABLE IF NOT EXISTS travel_cards(
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
    card_number CHAR(10) NOT NULL UNIQUE,
    job_during_journey ENUM( 'Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'),
    colonist_id INT(11),
    journey_id INT(11),
    FOREIGN KEY(colonist_id) REFERENCES colonists(id),
    FOREIGN KEY(journey_id) REFERENCES journeys(id)
);
