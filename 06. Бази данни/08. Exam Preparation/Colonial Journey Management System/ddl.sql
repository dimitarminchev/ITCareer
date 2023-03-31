-- Schema
-- CREATE DATABASE IF NOT EXISTS `colonial_journey_management_system`;
-- USE `colonial_journey_management_system`; 

-- Tables
CREATE TABLE planets 
(
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL
);
CREATE TABLE spaceports
(
    id INT AUTO_INCREMENT PRIMARY KEY,
    NAME VARCHAR(50) NOT NULL,
    planet_id INT,
    CONSTRAINT cj_spaceports_planets FOREIGN KEY (planet_id) REFERENCES planets(id)
);
CREATE TABLE spaceships
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    manufacturer VARCHAR(30) NOT NULL,
    light_speed_rate INT DEFAULT 0
);
CREATE TABLE colonists
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    ucn CHAR(10) NOT NULL UNIQUE,
    birth_date DATE NOT NULL,
    CONSTRAINT CHECK(LENGTH(ucn)=10)
);
CREATE TABLE journeys
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    journey_start DATETIME NOT NULL,
    journey_end DATETIME NOT NULL,
    purpose ENUM ('Medical','Technical','Educational','Military'),
    destination_spaceport_id INT,
    spaceship_id INT,
    CONSTRAINT cj_journeys_spaceports FOREIGN KEY (destination_spaceport_id) REFERENCES spaceports(id),
    CONSTRAINT cj_journeys_spaceships FOREIGN KEY (spaceship_id) REFERENCES spaceships(id)
);
CREATE table travel_cards
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    card_number CHAR(10) NOT NULL UNIQUE CHECK(LENGTH(card_number)=10),
    job_during_journey ENUM ('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'),
    colonist_id INT,
    journey_id INT,
    CONSTRAINT cj_travelCards_colonist FOREIGN KEY (colonist_id) REFERENCES colonists(id),
    CONSTRAINT cj_travelCards_journeys FOREIGN KEY (journey_id) REFERENCES journeys(id)
);

-- Data
insert into planets (id, name) values (1, 'Otroyphus');
insert into planets (id, name) values (2, 'Suthiyclite');
insert into planets (id, name) values (3, 'Lescore');
insert into planets (id, name) values (4, 'Wescapus');
insert into planets (id, name) values (5, 'Teutera');
insert into planets (id, name) values (6, 'Wueyama');
insert into planets (id, name) values (7, 'Slagonope');
insert into planets (id, name) values (8, 'Chumeter');
insert into planets (id, name) values (9, 'Whora');
insert into planets (id, name) values (10, '5Q5');
insert into planets (id, name) values (11, 'Gleshan');
insert into planets (id, name) values (12, 'WR8');
insert into planets (id, name) values (13, 'Feblunus');
insert into planets (id, name) values (14, 'Aswuenerth');
insert into planets (id, name) values (15, 'Kascarth');
insert into planets (id, name) values (16, 'Casmadus');
insert into planets (id, name) values (17, 'Jeayama');
insert into planets (id, name) values (18, 'Eipra');
insert into planets (id, name) values (19, 'Pleceliv');
insert into planets (id, name) values (20, 'Stenurilia');


insert into spaceports (id, name, planet_id) values (1, 'Miracle Colony', 15);
insert into spaceports (id, name, planet_id) values (2, 'Horus Colony', 18);
insert into spaceports (id, name, planet_id) values (3, 'Torus Base', 5);
insert into spaceports (id, name, planet_id) values (4, 'Rebus Station', 10);
insert into spaceports (id, name, planet_id) values (5, 'Zeus Colony', 5);
insert into spaceports (id, name, planet_id) values (6, 'Sol', 11);
insert into spaceports (id, name, planet_id) values (7, 'Epitome Station', 17);
insert into spaceports (id, name, planet_id) values (8, 'Olympus Terminal', 19);
insert into spaceports (id, name, planet_id) values (9, 'Minerva Station', 16);
insert into spaceports (id, name, planet_id) values (10, 'Illume', 7);
insert into spaceports (id, name, planet_id) values (11, 'Themis', 5);
insert into spaceports (id, name, planet_id) values (12, 'Epiphany Colony', 10);
insert into spaceports (id, name, planet_id) values (13, 'Artemis', 19);
insert into spaceports (id, name, planet_id) values (14, 'Borealis Colony', 7);
insert into spaceports (id, name, planet_id) values (15, 'Juno Station', 3);
insert into spaceports (id, name, planet_id) values (16, 'Phantom Station', 19);
insert into spaceports (id, name, planet_id) values (17, 'Orphan Station', 17);
insert into spaceports (id, name, planet_id) values (18, 'Ark Terminal', 18);
insert into spaceports (id, name, planet_id) values (19, 'Nemo Colony', 13);
insert into spaceports (id, name, planet_id) values (20, 'Hypnos', 12);
insert into spaceports (id, name, planet_id) values (21, 'Nebula Base', 1);
insert into spaceports (id, name, planet_id) values (22, 'Inception Station', 2);
insert into spaceports (id, name, planet_id) values (23, 'Tartarus', 3);
insert into spaceports (id, name, planet_id) values (24, 'Phantom Colony', 20);
insert into spaceports (id, name, planet_id) values (25, 'Yggdrasil Station', 15);
insert into spaceports (id, name, planet_id) values (26, 'Fable Terminal', 17);
insert into spaceports (id, name, planet_id) values (27, 'Paradox Station', 15);
insert into spaceports (id, name, planet_id) values (28, 'Zion Terminal', 9);
insert into spaceports (id, name, planet_id) values (29, 'Angel Station', 15);
insert into spaceports (id, name, planet_id) values (30, 'Aeris', 1);

insert into colonists (id, first_name, last_name, ucn, birth_date) values (1, 'Llywellyn', 'Gethouse', '4339438960', '1970-07-17');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (2, 'Ginny', 'de Zamora', '5915319416', '1958-12-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (3, 'Gabie', 'Burthom', '1762102897', '1961-03-03');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (4, 'Mitchell', 'Cortez', '8511063943', '1983-12-29');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (5, 'Kiah', 'Saywood', '1602343357', '1971-11-28');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (6, 'Clark', 'Cowan', '3675463850', '1956-03-31');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (7, 'Donny', 'Rosewarne', '9303158830', '1993-09-16');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (8, 'Sheffie', 'Stovine', '0591855062', '1982-08-13');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (9, 'Irv', 'Hargate', '3738050981', '1958-03-10');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (10, 'Bink', 'Uccelli', '0309591317', '1957-06-01');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (11, 'Ximenez', 'Piggot', '0887173071', '1974-09-02');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (12, 'Nicolai', 'Pering', '9032193457', '1994-10-03');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (13, 'Angeline', 'Sibley', '6739912092', '1972-01-20');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (14, 'Mic', 'Westbury', '1277343942', '1951-04-26');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (15, 'Filippo', 'Scutter', '4702812238', '1973-10-31');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (16, 'Ronalda', 'Mowsley', '1893106179', '1957-09-21');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (17, 'Roslyn', 'Gatus', '3407200129', '1996-12-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (18, 'Wald', 'Bim', '5432110725', '1990-01-04');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (19, 'Brigg', 'Paulo', '1923893793', '1965-04-04');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (20, 'Marillin', 'Pagen', '8648568714', '1956-10-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (21, 'Edita', 'Leiden', '4378763079', '1957-10-29');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (22, 'Brenna', 'Gidley', '8702130203', '1959-12-31');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (23, 'Bernelle', 'Nobes', '9570880503', '1984-06-24');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (24, 'Joaquin', 'Gheeraert', '5477599685', '1965-10-18');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (25, 'Hale', 'O''Doireidh', '2977107460', '1951-05-09');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (26, 'Timi', 'Blacksell', '1329244257', '1991-07-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (27, 'Winn', 'Moehle', '1021140996', '1964-01-27');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (28, 'Oberon', 'Filyakov', '1057711896', '1959-02-05');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (29, 'Annabelle', 'Okker', '9101545213', '1956-06-23');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (30, 'Arel', 'Power', '0930849914', '1980-03-14');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (31, 'Vilma', 'Ferriday', '2097283276', '1985-10-17');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (32, 'Kerr', 'Lody', '7735485093', '1953-04-24');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (33, 'Cart', 'Lyptrade', '9262146426', '1996-03-02');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (34, 'Philly', 'Randalston', '9875674540', '1977-08-07');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (35, 'Aigneis', 'McConville', '9225403496', '1991-12-01');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (36, 'Bradley', 'Cattow', '8115624241', '1987-02-19');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (37, 'Puff', 'Woods', '7888873006', '1968-07-26');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (38, 'Michell', 'Chapman', '4374713298', '1952-02-04');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (39, 'Fionnula', 'Jankiewicz', '9608520029', '1975-07-03');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (40, 'Mahmud', 'Satford', '1715614321', '1952-11-16');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (41, 'Laurie', 'Askin', '2713419093', '1954-04-05');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (42, 'Domeniga', 'De Pero', '0818480742', '1969-05-03');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (43, 'Michal', 'Abilowitz', '7650649482', '1988-03-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (44, 'Tobit', 'McCorkell', '7537611815', '1992-07-07');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (45, 'Constanta', 'Mardlin', '2145571876', '1965-06-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (46, 'Tessi', 'Oylett', '4568989884', '1972-11-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (47, 'Barrie', 'Drinkhall', '4410917234', '1983-07-11');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (48, 'Lezley', 'Fleischer', '5461541003', '1992-05-23');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (49, 'Elka', 'Kayley', '5642134000', '1973-12-11');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (50, 'Royal', 'Cuerdale', '6530389628', '1995-12-14');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (51, 'Skipp', 'Scrivner', '7605680473', '1951-04-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (52, 'Esmaria', 'Orrah', '5715982049', '1996-09-09');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (53, 'Gwendolyn', 'Spataro', '3333684268', '1988-03-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (54, 'Mollie', 'Renish', '3927497282', '1995-06-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (55, 'Dare', 'Coogan', '9721652350', '1980-12-05');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (56, 'Emmaline', 'McCabe', '6672282874', '1958-01-04');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (57, 'Tania', 'Trinbey', '2936617863', '1975-09-22');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (58, 'Karie', 'Dewing', '6257353688', '1969-09-04');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (59, 'Auria', 'Bernadot', '6077478105', '1989-06-10');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (60, 'Sioux', 'Temblett', '7865206178', '1952-03-26');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (61, 'Reid', 'Kiera', '8944188416', '1981-07-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (62, 'Christophe', 'Kench', '7520063968', '1997-01-21');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (63, 'Klara', 'Fratson', '5145463413', '1991-11-16');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (64, 'Cazzie', 'Stag', '8231774920', '1982-11-22');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (65, 'Nanon', 'Davydychev', '7731782581', '1959-08-10');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (66, 'Ralph', 'Elderfield', '0368613577', '1989-01-13');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (67, 'Barbara-anne', 'Telfer', '8149737006', '1956-04-24');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (68, 'Lynde', 'Bleue', '7047489932', '1966-11-13');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (69, 'Ezequiel', 'Lownsbrough', '6203647039', '1995-08-30');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (70, 'Town', 'Warcop', '9111417641', '1985-08-14');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (71, 'Roselia', 'Croce', '5268822853', '1967-06-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (72, 'Millisent', 'Girardini', '1440409919', '1961-09-26');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (73, 'Celia', 'Punshon', '2945848996', '1964-08-07');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (74, 'Sherilyn', 'Cantor', '7082752296', '1950-08-05');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (75, 'Natal', 'Adel', '5026822223', '1986-05-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (76, 'Reinwald', 'Greenwell', '7777836307', '1995-04-16');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (77, 'Gerry', 'Zorzin', '6088954132', '1996-08-14');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (78, 'Belva', 'Nend', '9589437826', '1994-04-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (79, 'Nerta', 'Leonardi', '1646136039', '1961-09-17');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (80, 'Rollins', 'Ivison', '9378662773', '1959-07-10');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (81, 'Kennith', 'Teasell', '0361925158', '1967-06-27');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (82, 'Hettie', 'Ord', '5878469642', '1992-08-17');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (83, 'Gretta', 'Adds', '4495697269', '1993-01-05');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (84, 'Sheena', 'Oleszkiewicz', '0516669745', '1959-08-09');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (85, 'Ive', 'Bowkett', '6334466569', '1973-11-18');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (86, 'Jock', 'Holbie', '4434406051', '1952-07-15');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (87, 'Tierney', 'Shrimptone', '4384489900', '1988-04-17');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (88, 'Norbie', 'Dallaway', '8110968600', '1952-09-11');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (89, 'Mora', 'Kristiansen', '5850225161', '1960-11-07');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (90, 'Mickey', 'Satterfitt', '5939528198', '1984-10-20');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (91, 'Faulkner', 'Daye', '2745264443', '1955-06-19');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (92, 'Althea', 'Kelinge', '9998159318', '1957-03-23');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (93, 'Kirstin', 'Steade', '7311418755', '1959-06-29');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (94, 'Chantalle', 'Filipputti', '0934906106', '1952-12-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (95, 'Far', 'Shrieves', '8673439787', '1956-04-07');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (96, 'Benito', 'Freke', '1458369730', '1994-02-19');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (97, 'Roxi', 'Restieaux', '2886137715', '1981-05-22');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (98, 'Nicolai', 'Creasey', '9690600435', '1970-09-06');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (99, 'Bern', 'Goldsack', '5733358580', '1963-01-25');
insert into colonists (id, first_name, last_name, ucn, birth_date) values (100, 'Eadmund', 'Le Gall', '1986195685', '1967-01-01');

insert into spaceships (id, name, manufacturer, light_speed_rate) values (1, 'USS Templar', 'Oyoba', 1);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (2, 'Anarchy', 'Fivebridge', 6);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (3, 'LWSS Romulus', 'Camimbo', 2);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (4, 'LWSS Dark Phoenix', 'Quimba', 4);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (5, 'BC The Commissioner', 'Jamaika', 5);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (6, 'BS Saratoga', 'Realbridge', 7);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (7, 'SC Serpent', 'Agivu', 9);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (8, 'Katherina', 'Skiba', 1);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (9, 'Messenger', 'Leenti', 3);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (10, 'SSE Priestess', 'Zoovu', 10);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (11, 'Mercenary Star', 'Realbridge', 1);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (12, 'Judgment', 'Quimba', 3);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (13, 'Fade', 'Camimbo', 5);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (14, 'Adder', 'Fivebridge', 7);
insert into spaceships (id, name, manufacturer, light_speed_rate) values (15, 'CS Hannibal', 'Oyoba', 9);

insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (1, '2019-02-09 17:02:46', '2049-04-20 22:39:54', 'Educational', 25, 10);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (2, '2019-01-28 20:27:45', '2049-11-21 00:08:27', 'Educational', 30, 11);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (3, '2019-02-21 22:06:34', '2049-01-03 11:00:22', 'Military', 9, 1);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (4, '2019-02-08 13:38:42', '2049-05-13 00:55:53', 'Educational', 23, 9);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (5, '2019-02-11 19:14:50', '2049-05-04 00:01:03', 'Technical', 19, 15);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (6, '2019-02-23 03:26:28', '2049-10-26 03:38:15', 'Military', 21, 8);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (7, '2019-01-04 23:44:40', '2049-12-09 04:00:54', 'Military', 21, 13);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (8, '2019-02-13 20:56:47', '2049-11-21 08:26:34', 'Medical', 19, 14);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (9, '2019-02-22 08:37:15', '2049-04-25 13:52:19', 'Educational', 18, 12);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (10, '2019-02-04 20:11:09', '2049-11-12 23:12:16', 'Medical', 25, 4);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (11, '2019-02-13 20:20:05', '2049-01-17 04:59:17', 'Medical', 3, 6);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (12, '2019-02-23 06:20:49', '2049-03-15 22:56:39', 'Military', 23, 2);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (13, '2019-02-19 16:40:06', '2049-02-22 02:52:23', 'Educational', 10, 5);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (14, '2019-01-31 18:12:01', '2049-03-22 20:54:18', 'Medical', 30, 3);
insert into journeys (id, journey_start, journey_end, purpose, destination_spaceport_id, spaceship_id) values (15, '2019-02-26 17:52:04', '2049-02-28 05:32:46', 'Technical', 2, 7);

insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (1, '8146587399', 'Trooper', 46, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (2, '2118029497', 'Engineer', 90, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (3, '9344537232', 'Trooper', 16, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (4, '9486883343', 'Trooper', 53, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (5, '1376917726', 'Engineer', 77, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (6, '6203185566', 'Trooper', 65, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (7, '7213731939', 'Trooper', 38, 12);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (8, '0916463753', 'Cook', 4, 3);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (9, '3171574225', 'Cleaner', 78, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (10, '7052651017', 'Trooper', 5, 3);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (11, '6485601252', 'Trooper', 21, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (12, '1259573990', 'Pilot', 39, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (13, '8094792329', 'Engineer', 73, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (14, '6625314714', 'Trooper', 79, 13);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (15, '9424426321', 'Cleaner', 17, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (16, '8828605863', 'Pilot', 54, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (17, '2159992313', 'Cook', 52, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (18, '3485558516', 'Trooper', 86, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (19, '2986646980', 'Cleaner', 91, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (20, '6684972129', 'Cook', 32, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (21, '4124832877', 'Pilot', 40, 13);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (22, '6235688229', 'Pilot', 18, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (23, '0696213079', 'Pilot', 68, 3);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (24, '4013832577', 'Cleaner', 34, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (25, '7294888914', 'Engineer', 11, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (26, '2452199249', 'Engineer', 44, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (27, '8109770304', 'Cook', 47, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (28, '0065437969', 'Engineer', 59, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (29, '2027180494', 'Cleaner', 19, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (30, '7428446880', 'Cook', 89, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (31, '9887148008', 'Pilot', 31, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (32, '7217275873', 'Trooper', 51, 13);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (33, '2107121109', 'Cleaner', 83, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (34, '6762392385', 'Pilot', 6, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (35, '7283381686', 'Engineer', 66, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (36, '9136252824', 'Trooper', 27, 11);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (37, '1245875957', 'Engineer', 70, 4);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (38, '6672774165', 'Cook', 41, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (39, '3195824760', 'Trooper', 62, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (40, '1747094374', 'Cook', 43, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (41, '7027727544', 'Cleaner', 85, 3);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (42, '2171192356', 'Engineer', 35, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (43, '5954191700', 'Cleaner', 8, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (44, '4095388420', 'Cleaner', 92, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (45, '9314496627', 'Cook', 2, 11);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (46, '1773187996', 'Pilot', 30, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (47, '8355604253', 'Trooper', 50, 12);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (48, '2988992428', 'Trooper', 49, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (49, '1659856329', 'Cook', 80, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (50, '0044135076', 'Trooper', 63, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (51, '9516474373', 'Cleaner', 14, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (52, '4157082869', 'Cleaner', 55, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (53, '8642394846', 'Pilot', 94, 8);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (54, '7519103471', 'Cook', 56, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (55, '1438175310', 'Cleaner', 12, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (56, '9204929723', 'Engineer', 74, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (57, '2593519746', 'Cleaner', 23, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (58, '1668303752', 'Trooper', 75, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (59, '5216557148', 'Cook', 28, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (60, '3947076819', 'Engineer', 71, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (61, '9289794623', 'Cook', 3, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (62, '6742541032', 'Cleaner', 7, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (63, '1199734136', 'Engineer', 37, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (64, '2868171206', 'Engineer', 29, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (65, '4584707200', 'Trooper', 33, 4);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (66, '9383154640', 'Trooper', 42, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (67, '6664373122', 'Trooper', 10, 10);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (68, '4084900842', 'Cleaner', 69, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (69, '2601229160', 'Trooper', 13, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (70, '9893913284', 'Pilot', 81, 8);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (71, '8132506049', 'Cleaner', 88, 4);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (72, '0801743184', 'Cleaner', 1, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (73, '0129851787', 'Cleaner', 25, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (74, '0032031181', 'Engineer', 67, 14);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (75, '9551949137', 'Pilot', 82, 12);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (76, '8086387313', 'Pilot', 95, 4);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (77, '1958989509', 'Cleaner', 93, 8);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (78, '5284322916', 'Cook', 87, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (79, '4505522830', 'Cleaner', 57, 13);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (80, '2193535426', 'Cleaner', 72, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (81, '6318403418', 'Cleaner', 26, 4);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (82, '0157800563', 'Pilot', 64, 3);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (83, '3190011672', 'Trooper', 20, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (84, '6339112293', 'Trooper', 45, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (85, '8070064854', 'Cook', 58, 6);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (86, '2053374160', 'Pilot', 84, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (87, '6506342986', 'Cook', 15, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (88, '2689944235', 'Cook', 9, 11);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (89, '0037637193', 'Engineer', 24, 12);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (90, '2733009753', 'Engineer', 22, 7);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (91, '2716188963', 'Cook', 48, 15);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (92, '7933701663', 'Cleaner', 60, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (93, '8779697844', 'Cook', 76, 12);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (94, '0870475649', 'Cleaner', 36, 11);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (95, '1349628603', 'Pilot', 61, 8);