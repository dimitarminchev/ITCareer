/* university database */
create schema `university`;
use `university`;

create table `subjects`
(
	`subject_id` INT(11) NOT NULL primary key,
    `subject_name` varchar(50) 
);

create table `majors`
(
	`major_id` INT(11) NOT NULL primary key,
    `name` varchar(50) 
);

create table `students`
(
	`student_id` INT(11) NOT NULL primary key,
    `student_number` varchar(12),
    `student_name` varchar(50),
    `major_id` int(11),
     constraint `fk_major`
    foreign key(`major_id`)
    references `majors` (`major_id`)
);

create table `payments`
(
	`payment_id` INT(11) NOT NULL primary key,
    `payment__date` date,
    `payment_amount` decimal(8,2),
    `student_id` int(11),
     constraint `fk_student`
    foreign key(`student_id`)
    references `students` (`student_id`)
);

create table `agenda`
(
	`student_id` int(11),
    `subject_id` int(11),
    
    constraint `pk_student_subject`
    primary key(`student_id`,`subject_id`),
   
    constraint `fk_students`
    foreign key(`student_id`)
    references `students` (`student_id`),
    
    constraint `fk_subjects`
    foreign key(`subject_id`)
    references `subjects` (`subject_id`)
);