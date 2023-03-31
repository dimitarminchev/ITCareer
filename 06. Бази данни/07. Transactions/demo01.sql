/* FUNCTION `udf_project_weeks` */
DELIMITER $$
USE `soft_uni`$$
CREATE FUNCTION udf_project_weeks (start_date DATETIME, end_date DATETIME)
RETURNS INT
DETERMINISTIC
BEGIN
	DECLARE project_weeks INT;
	IF(end_date IS NULL) THEN
		SET end_date := NOW();	
	END IF;
	SET project_weeks := DATEDIFF(DATE(end_date), DATE(start_date)) / 7;
	RETURN project_weeks;
END
$$

/* USE `udf_project_weeks` */
SELECT p.project_id, 
DATE(p.start_date) AS 'start_date', 
DATE(p.end_date) AS 'end_date',
udf_project_weeks(p.start_date, p.end_date) AS 'project_weeks'
FROM projects AS p;
