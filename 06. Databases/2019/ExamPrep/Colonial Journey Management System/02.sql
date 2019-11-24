UPDATE journeys
SET purpose = 
(
	CASE
		WHEN id % 2 = 0 THEN 'Medical'
		WHEN id % 3 = 0 THEN 'Technical'
		WHEN id % 5 = 0 THEN 'Educational'
		WHEN id % 7 = 0 THEN 'Military'
		ELSE purpose
	END
);