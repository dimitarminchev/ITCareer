-- 07. Хранилища и потребители
SELECT r.id, r.name,COUNT(c.contributor_id) AS users
FROM repositories AS r
JOIN commits AS c ON r.id  = c.repository_id
GROUP BY r.name
ORDER BY 3 DESC, 1 ;