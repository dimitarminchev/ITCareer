-- 03. Delete
-- https://judge.softuni.bg/Contests/Practice/Index/1265#3

DELETE FROM colonists
WHERE id NOT IN
(
   SELECT colonist_id 
   FROM travel_cards
);