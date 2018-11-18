-- 204. Изтриване на данни
USE colonial_journey_management_system_db;

DELETE FROM colonists
WHERE id NOT IN
(
   SELECT colonist_id 
   FROM travel_cards
);