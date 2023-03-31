/* 4. Self-Join Relationship */

/* Create Table */
CREATE TABLE `teachers`
(
	`teacher_id` INT PRIMARY KEY,
    `name` TEXT,
    `manager_id` INT,
    
    /* Foreign key: manager_id => teachers.teacher_id */
    CONSTRAINT `fk_teacher_manager`
    FOREIGN KEY (`manager_id`) 
    REFERENCES `teachers`(`teacher_id`)
);

/* Insert Data*/
INSERT INTO `teachers` (`teacher_id`,`name`) VALUES (101,"John");
INSERT INTO `teachers` (`teacher_id`,`name`,`manager_id`) VALUES (105,"Mark",101);
INSERT INTO `teachers` (`teacher_id`,`name`,`manager_id`) VALUES (106,"Greta",101);
INSERT INTO `teachers` (`teacher_id`,`name`,`manager_id`) VALUES (102,"Maya",106);
INSERT INTO `teachers` (`teacher_id`,`name`,`manager_id`) VALUES (103,"Silvia",106);
INSERT INTO `teachers` (`teacher_id`,`name`,`manager_id`) VALUES (104,"Ted",105);
