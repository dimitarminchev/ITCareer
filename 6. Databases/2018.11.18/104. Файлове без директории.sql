-- 04.Файлове без директории
SELECT f.id, f.name AS `Name`,CONCAT(f.size,"KB") AS size
FROM files AS f
WHERE f.id  NOT IN (
	SELECT parent_id FROM files
    WHERE parent_id IS NOT NULL 
)
ORDER BY 1;
