/* 16. Намерете първите 10 започнати проекти */
USE soft_uni;
SELECT project_id as id,Name,Description,start_date,end_date
FROM projects
ORDER BY start_date, Name
LIMIT 10;