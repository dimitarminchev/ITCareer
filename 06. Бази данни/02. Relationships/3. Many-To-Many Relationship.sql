/* 3. Many-To-Many Relationship */

/* Create Tables */
CREATE TABLE `students`
(
	`student_id` INT NOT NULL PRIMARY KEY,
	`name` TEXT
);

CREATE TABLE `exams`
(
	`exam_id` INT NOT NULL PRIMARY KEY,
	`name` TEXT
);

CREATE TABLE `students_exams`
(
	`student_id` INT,
	`exam_id` INT,
    
    /* Primary key */
    CONSTRAINT `pk_students_exams`
	PRIMARY KEY(`student_id`, `exam_id`),
	
    /* Foreign key: student_id => students.student_id */
	CONSTRAINT `fk_student_id`
	FOREIGN KEY(`student_id`)
	REFERENCES `students`(`student_id`),
	
    /* Foreign key: exam_id => exams.exam_id */
	CONSTRAINT `fk_exam_id`
	FOREIGN KEY(`exam_id`)
	REFERENCES `exams`(`exam_id`)
);

/* Insert Data */
INSERT INTO `students` (`student_id`,`name`) VALUES (1,"Mila");
INSERT INTO `students` (`student_id`,`name`) VALUES (2,"Toni");
INSERT INTO `students` (`student_id`,`name`) VALUES (3,"Ron");

INSERT INTO `exams` (`exam_id`,`name`) VALUES (101,"Spring MVC");
INSERT INTO `exams` (`exam_id`,`name`) VALUES (102,"Neo4j");
INSERT INTO `exams` (`exam_id`,`name`) VALUES (103,"Oracle 11g");

INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (1, 101);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (1, 102);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 101);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (3, 103);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 102);
INSERT INTO `students_exams` (`student_id`,`exam_id`) VALUES (2, 103);
