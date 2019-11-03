/* 4.4. Да се изведе списък с имената на всички планини и реки */
(
	SELECT `river_name` AS `name`, "River" AS `type`
    FROM `geography`.`rivers`
)
UNION 
(
	SELECT `mountain_range` AS `name`, "Mountain" AS `type`
    FROM `geography`.`mountains`
);
