-- 07. Хранилища и потребители
SELECT r.id, name, COUNT(c.contributor_id) AS users
FROM repositories r
LEFT JOIN (
	SELECT repository_id, contributor_id
    FROM commits
    GROUP BY repository_id, contributor_id
) AS c ON c.repository_id = r.id
GROUP BY name
ORDER BY users DESC, r.id;