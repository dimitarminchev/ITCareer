/* 223. Many to Many Relationship */
CREATE SCHEMA db223;
USE db223;

CREATE TABLE students(
	student_id INT AUTO_INCREMENT,
	name VARCHAR(25) NOT NULL,
	CONSTRAINT pk_db223_students PRIMARY KEY(student_id)
);

CREATE TABLE exams(
	exam_id INT AUTO_INCREMENT,
	name VARCHAR(25) NOT NULL,
	CONSTRAINT pk_db223_exams PRIMARY KEY(exam_id)
) AUTO_INCREMENT=101;

CREATE TABLE students_exams(
	student_id INT ,
	exam_id INT ,
	PRIMARY KEY(student_id,exam_id),
    FOREIGN KEY(student_id) REFERENCES students(student_id),
    FOREIGN KEY(exam_id) REFERENCES exams(exam_id)
);

INSERT INTO exams(name)
VALUES ('Spring MVC'),('Neo4j'),('Oracle 11g');

INSERT INTO students(name)
VALUES ('Mila'),('Toni'),('Ron');

INSERT INTO students_exams(student_id,exam_id)
VALUES (1,101),(1,102),(2,101),(1,103),(2,102),(2,103);







