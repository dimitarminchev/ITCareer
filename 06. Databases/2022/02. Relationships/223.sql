/* Task 2.2.3 */

CREATE TABLE `students`
(
	`student_id` INT NOT NULL PRIMARY KEY,
	`name` TEXT
);

INSERT INTO `students` (`student_id`,`name`) VALUES (1,"Mila");
INSERT INTO `students` (`student_id`,`name`) VALUES (2,"Toni");
INSERT INTO `students` (`student_id`,`name`) VALUES (3,"Ron");

CREATE TABLE `exams`
(
	`exam_id` INT NOT NULL PRIMARY KEY,
	`name` TEXT
);

INSERT INTO `exams` (`exam_id`,`name`) VALUES (101,"Spring MVC");
INSERT INTO `exams` (`exam_id`,`name`) VALUES (102,"Neo4j");
INSERT INTO `exams` (`exam_id`,`name`) VALUES (103,"Oracle 11g");

CREATE TABLE `students_exams`
(
	`student_id` INT,
	`exam_id` INT,
    
    /* primary key */
    CONSTRAINT `pk_students_exams`
	PRIMARY KEY(`student_id`, `exam_id`),
	
    /* forein key: student_id => students.student_id */
	CONSTRAINT `fk_students_exams_students`
	FOREIGN KEY(`student_id`)
	REFERENCES `students`(`student_id`),
	
    /* forein key: exam_id => exams.exam_id */
	CONSTRAINT `fk_students_exams_exams`
	FOREIGN KEY(`exam_id`)
	REFERENCES `exams`(`exam_id`)
);

INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (1, 101);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (1, 102);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 101);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (3, 103);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 102);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 103);
