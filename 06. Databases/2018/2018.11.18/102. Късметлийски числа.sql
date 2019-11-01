-- 02. Късметлийски числа
SELECT repository_id, contributor_id
FROM repositories_contributors
WHERE repository_id =contributor_id
ORDER BY 1,2 ASC;