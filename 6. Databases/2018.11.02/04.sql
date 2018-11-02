/* 04. Намерете първите 10 започнати проекта */
USE soft_uni;

SELECT * FROM projects
ORDER BY start_date, name
LIMIT 10; 
