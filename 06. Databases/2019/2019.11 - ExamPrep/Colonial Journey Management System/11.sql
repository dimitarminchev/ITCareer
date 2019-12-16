SELECT * FROM
(
	SELECT pl.name AS planet_name,
	(
		SELECT COUNT(*) AS cnt
		FROM journeys AS j
		JOIN spaceports AS p ON j.destination_spaceport_id = p.id
		WHERE p.planet_id = pl.id
		HAVING cnt > 0
	) AS journeys_count
	FROM planets AS pl
	ORDER BY journeys_count DESC, pl.name ASC
) AS c
WHERE c.journeys_count IS NOT NULL;