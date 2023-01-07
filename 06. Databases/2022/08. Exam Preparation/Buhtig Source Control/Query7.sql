/*
07. Хранилища и потребители
Извлечение от базата данни за всяко хранилище - броят на потребителите, 
които са се ангажирали с него.
ЗАБЕЛЕЖКА: 1 потребител може да има повече от 1 потвърждения в хранилище.
Подредете резулатите в низходящ ред по броя на потребители в хранилище и 
по id на хранилището.
*/
SELECT re.id, re.name, COUNT(DISTINCT c.contributor_id) AS users
FROM repositories AS re
LEFT JOIN commits AS c ON re.id = c.repository_id
GROUP BY re.id
ORDER BY users DESC, id;
