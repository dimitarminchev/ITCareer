CREATE DATABASE IF NOT EXISTS `colonial_journey_management_system_db`;

CREATE TABLE IF NOT EXISTS `planets`
(
	`id` int primary key auto_increment,
    `name` varchar(30) not null
);

CREATE TABLE IF NOT EXISTS `spaceports`
(
	`id` int primary key auto_increment,
    `name` varchar(50) not null,
    `planet_id` int,
    foreign key (`planet_id`) references `planets` (`id`)
);

CREATE TABLE IF NOT EXISTS `spaceships`
(
	`id` int primary key auto_increment,
    `name` varchar(50) not null,
    `manufacturer` varchar(30) not null,
    `light_speed_rate` int default 0
);

CREATE TABLE IF NOT EXISTS colonists
(
	`id` int primary key auto_increment,
    `first_name` varchar(20) not null,
    `last_name` varchar(20) not null,
    `ucn` char(10) unique key not null,
    `birth_date` date not null
);

CREATE TABLE IF NOT EXISTS journeys
(
	`id` int primary key auto_increment,
    `journey_start` datetime,
    `journey_end` datetime,
    `purpose` enum("Medical", "Technical", "Educational", "Military"),
    `destination_spaceport_id` int,
    foreign key (`destination_spaceport_id`) references `spaceports` (`id`),
    `spaceship_id` int,
    foreign key (`spaceship_id`) references `spaceships` (`id`)
);

CREATE TABLE IF NOT EXISTS `travel_cards`
(
	`id` int primary key auto_increment,
    `card_number` char(10) unique key not null,
    `job_during_journey` enum("Pilot", "Engineer", "Trooper", "Cleaner", "Cook"),
    `colonist_id` int,
    foreign key (`colonist_id`) references `colonists` (`id`),
    `journey_id` int,
    foreign key (`journey_id` ) references `journeys` (`id`)
);