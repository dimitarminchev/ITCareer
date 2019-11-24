/*
07. Хранилища и потребители
Извлечение от базата данни за всяко хранилище - броят на потребителите, 
които са се ангажирали с него.
ЗАБЕЛЕЖКА: 1 потребител може да има повече от 1 потвърждения в хранилище.
Подредете резулатите в низходящ ред по броя на потребители в хранилище и 
по id на хранилището.
*/

-- part 1
(
	SELECT r.id,r.`name`, COUNT(c.contributor_id) AS users
	FROM repositories AS r, commits AS c
	WHERE r.id = c.repository_id
	GROUP BY r.id
	ORDER BY users DESC, id
)

UNION

-- part 2
(
	SELECT r.id, r.`name`, "0" AS users
	FROM repositories AS r
	LEFT JOIN commits AS c ON r.id = c.repository_id 
	WHERE c.repository_id IS NULL
)
ORDER BY users DESC, id;
