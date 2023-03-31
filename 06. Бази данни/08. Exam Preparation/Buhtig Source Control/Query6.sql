/*
06. Хранилището с най-много участници
Извличане от базата данни, най-доброто хранилище от гледна точка на броя на участниците в него.
Ако две хранилища имат еднакъв брой участници, 
подрдете ги във възходящ ред по id на хранилището.
*/

SELECT r.id, r.`name`,
(
	SELECT COUNT(c.id) 
    FROM commits AS c 
    WHERE c.repository_id = r.id GROUP BY r.id
) as commits, COUNT(rc.contributor_id) as contributors
FROM repositories_contributors AS rc, repositories AS r
WHERE rc.repository_id = r.id 
GROUP BY r.id
ORDER BY contributors DESC, id ASC
LIMIT 1;
