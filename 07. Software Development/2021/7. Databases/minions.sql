CREATE TABLE Countries
(
	Id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) NOT NULL
);

CREATE TABLE Towns
(
	Id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	CountryCode INT,
	CONSTRAINT FK_Towns_Countries FOREIGN KEY (CountryCode) REFERENCES Countries (Id)
)

CREATE TABLE Minions
(
Id INT IDENTITY PRIMARY KEY,
Name VARCHAR(100) NOT NULL,
Age INT,
TownId INT,
CONSTRAINT FK_Minions_Towns FOREIGN KEY (TownId) REFERENCES Towns (Id)
)

CREATE TABLE EvilnessFactors
(
	Id INT IDENTITY PRIMARY KEY,
 	Name VARCHAR(100) NOT NULL
)

CREATE TABLE Villains
(
Id INT IDENTITY PRIMARY KEY,
Name VARCHAR(100),
EvilnessFactorId INT,
CONSTRAINT FK_Villains_EvilnessFactors FOREIGN KEY (EvilnessFactorId) REFERENCES EvilnessFactors (Id)
)

CREATE TABLE MinionsVillains
(
MinionId INT,
VillainId INT,
CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId),
CONSTRAINT FK_MinionsVillains_Minions FOREIGN KEY (MinionId) REFERENCES Minions (Id),
CONSTRAINT FK_MinionsVillains_Villains FOREIGN KEY (VillainId) REFERENCES Villains (Id)
)

INSERT INTO Countries (Name) VALUES
('Albania'),
('Bulgaria'),
('Czech Republic'),
('Denmark'),
('Germany'),
('Greece'),
('Unatid States'),
('United Kindom');

INSERT INTO Towns(Name, CountryCode) VALUES
('Tirana', 1),
('Sofia', 2),
('Plovdiv', 2),
('Varna', 2),
('Burgas', 2),
('Prague', 3),
('Copenhagen', 4),
('Berlin', 5),
('Dortmund', 5),
('Dortmund', 5),
('Dusseldorf', 5),
('Athens', 6),
('Tessaloniki', 6),
('Wassington', 7),
('New York', 7),
('Los Angelis', 7),
('London', 8),
('Mancester', 8);

INSERT INTO Minions (Name, Age, TownId) VALUES
('Kevin', 13, 1),
('Bob',16,3),
('Steward', 45, 5),
('Allan', 156, 4),
('John', 23, 2),
('Stephan', 30, 2),
('Penka', 25, 1),
('Sirtakis', 45, 2),
('Muricos', 19, 3),
('Fat Garry', 30, 4),
('Tarikatos', 14, 5),
('Smaug', 180, 2),
('Gurcho', 23, 6),
('Hoplosh',26,2),
('Liven', 65, 4),
('Muskito', 42, 5),
('ZegZeg', 12, 6),
('Azis', 7, 3);

INSERT INTO EvilnessFactors (Name) VALUES
('Super Evil'),
('Too Evil'),
('Just Evil'),
('Normal'),
('Somewhat Good'),
('Too good to be a villain');

INSERT INTO Villains (Name, EvilnessFactorId) VALUES 
('Dath Vader', 2),
('Hannibal Lecter', 1),
('Voldemort', 3),
('The Joker', 2),
('Emperor Palpatin', 1),
('Sauron', 6),
('Jake Paul', 4),
('Hitler', 1),
('Donald Trump', 5),
('Franklin Roosevelt', 6);

INSERT MinionsVillains
(MinionId, VillainId)
VALUES
(1, 1),
(2, 4),
(3, 5),
(3, 3),
(1, 3),
(2, 2),
(4, 2),
(1, 6),
(4, 4),
(5, 5),
(1, 5),
(5, 1),
(6, 6),
(6, 1),
(1, 2),
(1, 4),
(3, 1),
(4, 1),
(4, 5),
(4, 3),
(3, 2);