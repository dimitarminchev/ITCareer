-- 04. Extract all travel cards 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#4

SELECT card_number, job_during_journey
FROM travel_cards
ORDER BY card_number ASC;