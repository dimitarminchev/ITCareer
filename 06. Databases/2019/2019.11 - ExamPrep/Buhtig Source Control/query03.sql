/*
03. Проблеми и потребители
Извлечете от базата данни всички проблеми и потребителите, които са им присвоени в следния формат:
{username} : {issueTitle}
Пордереде резултатите по id на проблема в низходящ ред.
*/	
SELECT issues.id, CONCAT(users.username," : ",issues.title) AS "issue_assignee"
FROM issues, users 
WHERE issues.assignee_id = users.id
ORDER BY issues.id DESC;	
