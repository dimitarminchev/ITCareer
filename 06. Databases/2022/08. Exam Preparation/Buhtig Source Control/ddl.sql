CREATE TABLE users ( 
id INT AUTO_INCREMENT primary key,
username varchar(30) NOT NULL UNIQUE,
password varchar(30) NOT NULL,
email varchar(50) NOT NULL 
);

CREATE TABLE repositories(
id INT auto_increment PRIMARY KEY,
name varchar(50) NOT NULL
);

CREATE TABLE repositories_contributors(
repository_id int,
contributor_id int
);

ALTER TABLE repositories_contributors
ADD CONSTRAINT fk_repositories_contributors_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE repositories_contributors
ADD CONSTRAINT fk_repositories_contributors_repositoriese foreign key(contributor_id)
references users(id);

CREATE TABLE issues(
id int auto_increment primary KEY,
title varchar(255) NOT NULL,
issue_status varchar(6) NOT NULL,
repository_id int NOT NULL,
assignee_id INT NOT NULL
);


ALTER TABLE issues
ADD CONSTRAINT fk_issues_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE issues
ADD CONSTRAINT fk_issues_users foreign key(assignee_id)
references users(id);

CREATE TABLE commits (
id INT auto_increment primary KEY,
message varchar(255) NOT NULL,
issue_id INT,
repository_id INT NOT NULL,
contributor_id INT NOT NULL
);

ALTER TABLE commits
ADD CONSTRAINT fk_commits_issues foreign key(issue_id)
references issues(id);

ALTER TABLE commits
ADD CONSTRAINT fk_commits_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE commits
ADD CONSTRAINT fk_commists_users foreign key(contributor_id)
references users(id);


create TABLE files (
id INT auto_increment primary key,
name varchar(100) NOT NULL,
size DECIMAL(10,2) NOT NULL,
parent_id int,
commit_id INT NOT NULL
);

ALTER TABLE files
ADD CONSTRAINT fk_files_files foreign key(parent_id)
references files(id);


ALTER TABLE files
ADD CONSTRAINT fk_files_commits foreign key(commit_id)
references commits(id);

#########################################################################
INSERT INTO users (id, username, password, email)
VALUES
(1, 'UnderSinduxrein', '4l8nYGTKMW', 'azfex@gmail.com'),
(2, 'BlaAntigadsa', ':Q5wjT4[e', 'kuf@abv.bg'),
(3, 'ANinedsa', 'El[MwhxY)J', 'indie@yahoo.com'),
(4, 'ScoreImmagidefon', '`NGU>oS', 'daffy@yandex.bg'),
(5, 'BlaSinduxrein', 'wJyfcwg*', 'toni@donald.eu'),
(6, 'WhoDenoteBel', 'ajmISQi*', 'tinny@pd.cd'),
(7, 'WhatTerrorBel', 'R+-<+..Pl3j^', 'joseph@lon.co.uk'),
(8, 'AryaDenotehow', 'NNY5<e=', 'corect@asd.asd'),
(9, 'UnveiledDenoteIana', 'no0*[ijt', 'default@ooo.com'),
(10, 'ScoreSinduxIana', '8xI:@-j2_.T', 'rog@asus.co'),
(11, 'RoundAntigaBel', '4S>7EUNeUC@kv', 'diplomat@po.bo'),
(12, 'DarkImmagidsa', 'R.fh[f1Zh>2', 'sys@admin.bg'),
(13, 'RoundInspecindi', 'AdKs>q]u7P`C', 'katr@kiper.eu'),
(14, 'AryaNinehow', 'X6j>`Huf2F(I', 'wrec@soft.wrap'),
(15, 'ScoreAntigarein', 'UUD3H))<', 'dec@int.float'),
(16, 'TheDivineBel', '-gCi:_Ub?ypT', 'rindiy@abv.bg'),
(17, 'RoundArmydsa', 'SZ?F-:hW', 'com@gmail.user'),
(18, 'HighAsmahow', 'lyqF\vUG', 'svik@kiwi.mandarin'),
(19, 'ZendArmyhow', 'DbW>9,', 'rip@pob.cid'),
(20, 'BlaImmagiIana', 'upE;fg6+)n', 'stun@asd.cdd');

INSERT INTO repositories (id, name)
VALUES
(1, 'WorkWork'),
(2, 'Tumbalore'),
(3, 'Softuni-Teamwork'),
(4, 'IncreaseRepo'),
(5, 'ContinuousIntegration'),
(6, 'IndigoDB'),
(7, 'DundaApp'),
(8, 'Citros'),
(9, 'BogoApp'),
(10, 'SortedTupleJS'),
(11, 'KartinaJS'),
(12, 'SpiralSort'),
(13, 'Vendigo-RPG'),
(14, 'Kartica'),
(15, 'SignalR'),
(16, 'ASP.NET'),
(17, 'MySQL'),
(18, 'InnoDB'),
(19, 'Catalina'),
(20, 'JosephineDB'),
(21, 'Intrigued-RPG'),
(22, 'Maxima'),
(23, 'Calculus'),
(24, 'Assembly-Force'),
(25, 'Mesmerize-Frameowork'),
(26, 'maxOut'),
(27, 'inspiration'),
(28, 'Bau'),
(29, 'Practiq'),
(30, 'Daun'),
(31, 'Kimmers'),
(32, 'Defalte_pf'),
(33, 'Kras_par_ti'),
(34, 'Antiq'),
(35, 'Dantelle'),
(36, 'DELET THIS');

INSERT INTO repositories_contributors(repository_id, contributor_id)
VALUES
(2, 15),
(26, 16),
(30, 2),
(16, 11),
(10, 15),
(28, 17),
(7, 19),
(22, 3),
(16, 4),
(25, 15),
(18, 5),
(30, 17),
(1, 14),
(1, 1),
(27, 1),
(12, 2),
(2, 16),
(16, 18),
(33, 12),
(30, 1),
(15, 17),
(3, 1),
(14, 4),
(28, 16),
(24, 15),
(29, 3),
(32, 19),
(3, 14),
(10, 2),
(13, 15),
(7, 1),
(15, 9),
(22, 5),
(5, 9),
(32, 16),
(25, 6),
(9, 13),
(29, 15),
(33, 14),
(9, 9),
(3, 3),
(22, 4),
(8, 5),
(21, 13),
(29, 5),
(5, 2),
(22, 10),
(2, 1),
(10, 19),
(17, 4),
(7, 7),
(20, 6),
(11, 1),
(18, 16),
(23, 18),
(32, 14),
(28, 13),
(29, 6),
(14, 7),
(1, 18),
(1, 10),
(26, 1),
(5, 12),
(34, 17),
(21, 3),
(8, 16),
(31, 13),
(13, 1),
(14, 8),
(13, 9),
(1, 6),
(32, 8),
(25, 12),
(19, 15),
(30, 12),
(30, 11),
(2, 3),
(24, 1),
(22, 9),
(34, 14),
(31, 16),
(11, 7),
(27, 10),
(6, 1),
(31, 1),
(4, 14),
(30, 19),
(6, 15),
(16, 2),
(10, 3),
(3, 17),
(9, 5),
(13, 7),
(7, 6),
(22, 8),
(23, 19),
(26, 11),
(3, 7),
(33, 1),
(27, 2);

INSERT INTO issues(id, title, issue_status, repository_id, assignee_id)
VALUES
(1, 'Invalid welcoming message in Controller.json', 'closed', 25, 5),
(2, 'Invalid welcoming message in READ.html', 'opened', 34, 13),
(3, 'Unreachable code in Find.java stops compilation flow', 'closed', 11, 11),
(4, 'Implement documentation for Jason.exe module', 'closed', 16, 5),
(5, 'Unreachable code in Model.MD stops compilation flow', 'closed', 6, 17),
(6, 'Security Flaw in Accelerate.dd inner code', 'opened', 5, 14),
(7, 'Compilation failed while trying to execute Bean.php', 'closed', 14, 14),
(8, 'Critical bug in sound.sick ruins application when executed', 'opened', 24, 11),
(9, 'Invalid welcoming message in Find.java', 'clear', 25, 12),
(10, 'Unreachable code in Index.class stops compilation flow', 'clear', 24, 4),
(11, 'Loose Cohesion and Strong Coupling in Beat.bat', 'clear', 34, 7),
(12, 'Compilation failed while trying to execute READ.img', 'closed', 16, 1),
(13, 'Critical bug in pipeline.dd ruins application when executed', 'clear', 3, 16),
(14, 'Implement documentation for Register.py module', 'clear', 1, 17),
(15, 'Compilation failed while trying to execute Search.py', 'clear', 19, 1),
(16, 'Inappropriate prompt from READ.html', 'fixed', 8, 1),
(17, 'Unreachable code in index.intro stops compilation flow', 'opened', 22, 9),
(18, 'Critical bug in Jason.exe ruins application when executed', 'opened', 29, 14),
(19, 'Compilation failed while trying to execute Beat.bat', 'closed', 10, 18),
(20, 'init.txt breaks down after startup', 'fixed', 4, 10),
(21, 'compile.png breaks down after startup', 'clear', 7, 9),
(22, 'Unreachable code in index.net stops compilation flow', 'fixed', 16, 9),
(23, 'Inappropriate prompt from index.net', 'closed', 18, 1),
(24, 'Implement documentation for index.intro module', 'closed', 9, 11),
(25, 'Invalid welcoming message in file.sick', 'clear', 20, 5),
(26, 'Unreachable code in Login.html stops compilation flow', 'fixed', 27, 1),
(27, 'Hotfix for security issue in View.dd introduces new security issue', 'clear', 30, 6),
(28, 'Hotfix for security issue in Jason.exe introduces new security issue', 'closed', 15, 2),
(29, 'Loose Cohesion and Strong Coupling in READ.img', 'fixed', 13, 8),
(30, 'Inappropriate prompt from config.dd', 'fixed', 29, 12),
(31, 'Invalid welcoming message in Administrate.soshy', 'closed', 12, 10),
(32, 'Hotfix for security issue in Index.class introduces new security issue', 'clear', 5, 16),
(33, 'Loose Cohesion and Strong Coupling in Bean.php', 'clear', 19, 8),
(34, 'Loose Cohesion and Strong Coupling in file.png', 'closed', 14, 16),
(35, 'Invalid welcoming message in Accelerate.sick', 'clear', 17, 14),
(36, 'Compilation failed while trying to execute index.intro', 'clear', 11, 19),
(37, 'Security Flaw in Music.jpg inner code', 'closed', 11, 11),
(38, 'index.db breaks down after startup', 'closed', 23, 8),
(39, 'Unreachable code in Music.jpg stops compilation flow', 'clear', 5, 19),
(40, 'Unimplemented exception thrown in Accelerate.sick', 'clear', 20, 1),
(41, 'Invalid welcoming message in Search.py', 'clear', 32, 14),
(42, 'Invalid welcoming message in index.cpp', 'clear', 26, 15),
(43, 'Compilation failed while trying to execute index.db', 'clear', 15, 1),
(44, 'Root.net breaks down after startup', 'fixed', 31, 5),
(45, 'Unimplemented exception thrown in init.txt', 'clear', 30, 2),
(46, 'Critical bug in compile.html ruins application when executed', 'opened', 3, 11),
(47, 'Inappropriate prompt from index.db', 'clear', 30, 14),
(48, 'Implement documentation for file.cpp module', 'opened', 12, 14),
(49, 'Inappropriate prompt from Register.py', 'fixed', 9, 2),
(50, 'Implement documentation for index.db module', 'fixed', 17, 7),
(51, 'Critical bug in Trade.idk ruins application when executed', 'clear', 27, 13),
(52, 'Unimplemented exception thrown in Beat.xix', 'fixed', 16, 6),
(53, 'Unimplemented exception thrown in Administrate.go', 'clear', 1, 17),
(54, 'Unimplemented exception thrown in Login.html', 'clear', 32, 1),
(55, 'Unreachable code in Register.py stops compilation flow', 'opened', 21, 18),
(56, 'Hotfix for security issue in pipeline.dd introduces new security issue', 'fixed', 27, 17),
(57, 'Invalid welcoming message in init.txt', 'fixed', 14, 15),
(58, 'Implement documentation for Administrate.soshy module', 'opened', 28, 1),
(59, 'Hotfix for security issue in index.soshy introduces new security issue', 'closed', 11, 3),
(60, 'Implement documentation for file.sick module', 'closed', 31, 10),
(61, 'Loose Cohesion and Strong Coupling in Root.net', 'closed', 13, 7),
(62, 'Compilation failed while trying to execute index.net', 'opened', 8, 19),
(63, 'Unimplemented exception thrown in Register.py', 'clear', 21, 19),
(64, 'file.sick breaks down after startup', 'closed', 35, 19),
(65, 'Security Flaw in pipeline.dd inner code', 'opened', 3, 19),
(66, 'Invalid welcoming message in index.intro', 'closed', 8, 6),
(67, 'Security Flaw in Beat.xix inner code', 'opened', 33, 7),
(68, 'Inappropriate prompt from compile.ivory', 'clear', 11, 4),
(69, 'Inappropriate prompt from Search.py', 'clear', 12, 17),
(70, 'Hotfix for security issue in Login.db introduces new security issue', 'clear', 2, 19),
(71, 'Implement documentation for Index.class module', 'closed', 32, 3),
(72, 'Loose Cohesion and Strong Coupling in index.soshy', 'opened', 29, 12),
(73, 'Loose Cohesion and Strong Coupling in Beat.html', 'opened', 2, 15),
(74, 'Compilation failed while trying to execute init.xml', 'opened', 24, 12),
(75, 'Critical bug in Controller.php ruins application when executed', 'fixed', 8, 16);

INSERT INTO commits(id, message, issue_id, repository_id, contributor_id)
VALUES
(1, 'Deleted deprecated functionality from index.cpp', 58, 17, 8),
(2, 'Created README.MD', 15, 14, 8),
(3, 'Initial Commit', 52, 24, 1),
(4, 'Implemented config.json functionality', 15, 10, 12),
(5, 'Deleted deprecated functionality from index.dd', 32, 13, 18),
(6, 'Hotfix for bug in Index.class', 71, 19, 1),
(7, 'Patch Index.javav.', 38, 8, 11),
(8, 'Deleted deprecated functionality from Operate.xix', NULL, 28, 9),
(9, 'Fixed security issue in file.png', NULL, 6, 2),
(10, 'Deleted deprecated functionality from index.net', NULL, 27, 1),
(11, 'Patch Model.MDv.', 52, 7, 16),
(12, 'Deleted deprecated functionality from Music.jpg', 41, 6, 11),
(13, 'Implemented index.net functionality', NULL, 15, 11),
(14, 'Fixed index.dd', 40, 1, 7),
(15, 'Fixed index.soshy', NULL, 19, 1),
(16, 'Patch Operate.xixv.', NULL, 21, 4),
(17, 'Hotfix for bug in Database.dd', 73, 14, 11),
(18, 'Hotfix for bug in init.xml', 3, 10, 11),
(19, 'Hotfix for bug in compile.png', 2, 7, 3),
(20, 'Fixed init.xml', 15, 30, 15),
(21, 'Hotfix for bug in Administrate.soshy', 8, 26, 19),
(22, 'Implemented Index.class functionality', NULL, 14, 13),
(23, 'Fixed security issue in Beat.bat', NULL, 7, 4),
(24, 'Patch index.netv.', 36, 16, 14),
(25, 'Implemented compile.png functionality', 21, 10, 2),
(26, 'Fixed security issue in compile.html', 72, 22, 4),
(27, 'Patch index.ddv.', 62, 6, 3),
(28, 'Fixed Controller.php', 4, 9, 7),
(29, 'Patch Find.javav.', 29, 28, 4),
(30, 'Hotfix for bug in compile.ivory', 43, 25, 14),
(31, 'Fixed security issue in compile.png', 64, 16, 10),
(32, 'Implemented Beat.bat functionality', NULL, 5, 18),
(33, 'Patch Database.ddv.', 17, 4, 15),
(34, 'Deleted deprecated functionality from Model.MD', 48, 17, 7),
(35, 'Patch init.txtv.', 51, 11, 2),
(36, 'Fixed menu.net', 48, 3, 18),
(37, 'Implemented Find.java functionality', NULL, 1, 1),
(38, 'Deleted deprecated functionality from index.intro', 70, 18, 16),
(39, 'Implemented Beat.html functionality', 51, 1, 5),
(40, 'Deleted deprecated functionality from Database.dd', NULL, 2, 13),
(41, 'Implemented Trade.idk functionality', NULL, 15, 19),
(42, 'Hotfix for bug in compile.html', 15, 6, 19),
(43, 'Fixed security issue in Search.py', 17, 21, 15),
(44, 'Fixed security issue in Accelerate.sick', 20, 2, 17),
(45, 'Fixed security issue in Administrate.soshy', 58, 25, 1),
(46, 'Fixed security issue in file.txt', NULL, 1, 14),
(47, 'Fixed Operate.xix', 29, 27, 15),
(48, 'Implemented init.xml functionality', 39, 7, 17),
(49, 'Fixed config.json', 1, 28, 5),
(50, 'Implemented Database.dd functionality', NULL, 29, 8);

INSERT INTO files(id, name, size, parent_id, commit_id)
VALUES
(1, 'Trade.idk', 2598.0, 1, 1),
(2, 'menu.net', 9238.31, 2, 2),
(3, 'Administrate.soshy', 1246.93, 3, 3),
(4, 'Controller.php', 7353.15, 4, 4),
(5, 'Find.java', 9957.86, 5, 5),
(6, 'Controller.json', 14034.87, 3, 6),
(7, 'Operate.xix', 7662.92, 7, 7),
(8, 'file.sick', 10548.35, 8, 8),
(9, 'config.dd', 8745.77, 9, 9),
(10, 'Index.java', 6121.35, 10, 10),
(11, 'compile.ivory', 1185.04, 11, 1),
(12, 'Model.MD', 4753.67, 3, 12),
(13, 'Beat.html', 907.3, 13, 13),
(14, 'READ.img', 2627.6, 14, 7),
(15, 'Search.py', 8831.43, 15, 15),
(16, 'Controller.intro', 27302.85, 11, 1),
(17, 'Login.html', 2863.23, 16, 17),
(18, 'Administrate.go', 24612.57, 9, 18),
(19, 'READ.html', 2396.47, 8, 1),
(20, 'index.net', 9261.71, 20, 20),
(21, 'Index.class', 4001.15, 21, 21),
(22, 'config.json', 6049.09, 22, 22),
(23, 'pipeline.dd', 18407.72, NULL, 19),
(24, 'Accelerate.dd', 23042.88, 24, 19),
(25, 'Database.dd', 14905.56, NULL, 25),
(26, 'Login.db', 8015.83, NULL, 21),
(27, 'Beat.bat', 21431.98, 25, 12),
(28, 'Jason.txt', 10317.54, NULL, 28),
(29, 'Jason.exe', 28209.18, 8, 25),
(30, 'Accelerate.idk', 5520.3, 30, 1),
(31, 'file.txt', 5514.02, 27, 1),
(32, 'Music.jpg', 917.75, 1, 3),
(33, 'Root.net', 6784.97, 8, 28),
(34, 'sound.sick', 8749.82, 20, 16),
(35, 'index.dd', 35942.21, NULL, 35),
(36, 'index.intro', 14325.29, 26, 36),
(37, 'init.xml', 40028.01, NULL, 22),
(38, 'file.cpp', 3038.23, NULL, 22),
(39, 'Beat.xix', 5877.21, 22, 31),
(40, 'index.cpp', 28912.18, 2, 40),
(41, 'compile.png', 20510.09, 22, 24),
(42, 'Register.py', 2037.26, 5, 27),
(43, 'init.txt', 16089.79, 28, 4),
(44, 'View.dd', 2470.36, NULL, 44),
(45, 'file.png', 7755.49, NULL, 23),
(46, 'index.db', 3821.36, 11, 46),
(47, 'Accelerate.sick', 5774.32, 47, 47),
(48, 'index.soshy', 30522.96, 30, 26),
(49, 'compile.html', 27402.59, 28, 24),
(50, 'Bean.php', 4184.45, 20, 35);

UPDATE files
SET parent_id = 42
WHERE id = 5;
