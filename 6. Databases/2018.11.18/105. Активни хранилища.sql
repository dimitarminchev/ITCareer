-- 05.Активни хранилища
SELECT r.id,r.name,COUNT(i.repository_id) AS issues
FROM repositories AS r
JOIN issues AS i ON r.id = i.repository_id
GROUP BY r.name
ORDER BY 3 DESC;


