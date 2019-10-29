/* 609. Age Groups */
USE gringotts;

DROP TABLE IF EXISTS table609;

CREATE TABLE IF NOT EXISTS table609
(
	age_group varchar(50),
	wizzard_count int(2)
);

INSERT INTO table609 
(
		SELECT '[0-10]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age <= 10
);
INSERT INTO table609  
(
		SELECT '[11-20]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 11 AND age <= 20
);
INSERT INTO table609 
(
		SELECT '[21-30]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 21 AND age <= 30
);
INSERT INTO table609 
(
		SELECT '[31-40]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 31 AND age <= 40
);
INSERT INTO table609 
(
		SELECT '[41-50]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 41 AND age <= 50
);
INSERT INTO table609 
(
		SELECT '[51-60]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 51 AND age <= 60
);
INSERT INTO table609 
(
		SELECT '[61+]' AS age_group, count(ID) AS wizzard_count
		FROM wizzard_deposits
		GROUP BY age HAVING age >= 61
);

SELECT age_group, SUM(wizzard_count) 
FROM table609
GROUP BY age_group;