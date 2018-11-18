-- 03.    Проблеми и потребители
SELECT i.id, CONCAT_WS(" : ",u.username,i.title) AS  issue_assignee 
FROM issues AS i
JOIN users AS u ON i.assignee_id = u.id
ORDER BY 1 DESC;
