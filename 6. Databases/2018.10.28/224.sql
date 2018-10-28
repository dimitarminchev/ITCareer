/* 224. Cross-Reference Relationship */
CREATE SCHEMA db224;
USE db224;

CREATE TABLE teachers(
	teacher_id INT NOT NULL,
    name VARCHAR(30) NOT NULL,
    manager_id INT NULL,
    PRIMARY KEY(teacher_id),
    FOREIGN KEY(manager_id) REFERENCES teachers(teacher_id)
);

INSERT INTO teachers(teacher_id, name)
VALUES
(101,'John');

INSERT INTO teachers(teacher_id, name, manager_id)
VALUES
(105,'Mark', 101),
(106,'Greta', 101),
(102,'Maya', 106),
(103,'Silvia', 106),
(104,'Ted', 105);