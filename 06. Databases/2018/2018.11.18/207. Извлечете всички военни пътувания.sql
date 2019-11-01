-- 207. Извлечете всички военни пътувания
USE colonial_journey_management_system_db;

SELECT id, journey_start, journey_end
FROM journeys
WHERE purpose = 'Military'
ORDER BY journey_start