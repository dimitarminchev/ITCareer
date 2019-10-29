CREATE DATABASE Minions;
USE Minions;

CREATE TABLE Countries
(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50) NOT NULL
);
 	 
CREATE TABLE Towns
(
 	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 	Name VARCHAR(50),
	CountryCode INT,
    FOREIGN KEY(CountryCode) REFERENCES Countries(Id)
);

CREATE TABLE Minions
(
 	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 	Name VARCHAR(50),
 	Age INT,
    TownId INT,
    FOREIGN KEY (TownId) REFERENCES Towns(Id)
);

CREATE TABLE EvilnessFactors
(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, 
 	Name VARCHAR(50)
);

CREATE TABLE Villains
(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, 
 	Name VARCHAR(50),
    EvilnessFactorId INT,
    FOREIGN KEY (EvilnessFactorId) REFERENCES EvilnessFactors(Id)
);

CREATE TABLE MinionsVillains
(
	MinionId INT,
    VillainId INT,
    FOREIGN KEY(MinionId) REFERENCES Minions(Id),
    FOREIGN KEY(VillainId) REFERENCES Villains(Id)
);

INSERT INTO Countries (Name) VALUES
("Albania"),
("Bulgaria"),
("Czech Republic"),
("Denmark"),
("Estonia"),
("Finland"),
("Germany"),
("Holland"),
("Ireland"),
("Japan"),
("Kosovo"),
("Lithuania"),
("Montenegro"),
("Norway"),
("Oman"),
("Pakistan"),
("Quebec"),
("Russia"),
("Switzerland"),
("Taiwan"),
("Ukraine"),
("Vietnam"),
("Yemen"),
("Zimbabwe");

INSERT INTO Towns(Name, CountryCode) VALUES
("Tirana", 1),
("Sofia", 2),
("Prague", 3),
("Copenhagen", 4),
("Berlin", 5);

INSERT INTO Minions (Name, Age, TownId) VALUES
("Gurcho", 13, 1),
("Hoplosh",16,3),
("Liven", 45, 5),
("Muskito", 156, 4),
("ZegZeg", 23, 2),
("Azis", 30, 2);

INSERT INTO EvilnessFactors (Name) VALUES
("Dreadful"),
("Too Evil"),
("Just Evil"),
("Normal"),
("Somewhat Good"),
("Too good to be a villain");

INSERT INTO Villains (Name, EvilnessFactorId) VALUES
("Jake Paul", 1),
("Hitler", 4),
("Donald Trump", 3),
("Boiko", 1),
("Franklin Roosevelt", 2);

INSERT INTO MinionsVillains(MinionId, VillainId) VALUES
(1,3),
(4,5),
(2,4),
(4,3),
(5,1),
(3,2);