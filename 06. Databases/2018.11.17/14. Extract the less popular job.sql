-- 14. Extract the less popular job 
-- https://judge.softuni.bg/Contests/Practice/Index/1265#14

SELECT tc.job_during_journey AS job_name
FROM travel_cards AS tc
WHERE tc.journey_id =
(
	SELECT j.id
    FROM journeys AS j
    ORDER BY DATEDIFF(j.journey_start, j.journey_end) ASC
    LIMIT 1
)
GROUP BY job_name
ORDER BY COUNT(*) ASC
LIMIT 1;