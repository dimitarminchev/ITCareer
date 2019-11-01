-- 205. Извлечете всички карти за пътуване
USE colonial_journey_management_system_db;

SELECT card_number, job_during_journey
FROM travel_cards
ORDER BY card_number ASC;