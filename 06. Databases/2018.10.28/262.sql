/* 262. Университетска база данни */
CREATE SCHEMA universitydb;
USE universitydb;

CREATE TABLE majors(
	major_id INT(11),
    name VARCHAR(50) NOT NULL,
    PRIMARY KEY(major_id)
);

CREATE TABLE subjects(
	subject_id INT(11),
    subject_name VARCHAR(50) NOT NULL,
    PRIMARY KEY(subject_id)
);

CREATE TABLE students(
	student_id INT(11),
    student_number VARCHAR(12) NOT NULL,
    student_name VARCHAR(50) NOT NULL,
    major_id INT(11),
    PRIMARY KEY(student_id),
    FOREIGN KEY(major_id) REFERENCES majors(major_id)
);

CREATE TABLE payments(
	payment_id INT(11),
    payment_date DATE NOT NULL,
    payment_amount DECIMAL(8,2) NOT NULL,
    student_id INT(11) NOT NULL,
    PRIMARY KEY(payment_id),
    FOREIGN KEY(student_id) REFERENCES students(student_id)
);

CREATE TABLE agenda(
	student_id INT(11) NOT NULL, 
    subject_id INT(11) NOT NULL,
    PRIMARY KEY(student_id, subject_id),
    FOREIGN KEY(student_id) REFERENCES students(student_id),
    FOREIGN KEY(subject_id) REFERENCES subjects(subject_id)
);
