/*
02. Късметлийски числа
Извлечете от базата данни всички хранилища, които имат едно и също id с id-то на сътрудника.
Подередете резултатите във възходящ ред по id на хранилището.
*/
SELECT repository_id, contributor_id
FROM repositories_contributors 
WHERE repository_id = contributor_id
ORDER BY repository_id;