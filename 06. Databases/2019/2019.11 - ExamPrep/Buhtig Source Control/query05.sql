/* 
05. Активни хранилища
Извлечете от базата данни, първите 5 хранилища, по отношение на броя на проблемите по тях.
Подредете резултатите в низходящ ред по броя на проблемите по тях и 
по id на хранилищетото във възходящ ред. 
*/
SELECT r.id,r.`name`,COUNT(i.id) AS issues
FROM repositories AS r, issues AS i
WHERE i.repository_id = r.id
GROUP BY i.repository_id
ORDER BY issues DESC, r.id
LIMIT 5;
