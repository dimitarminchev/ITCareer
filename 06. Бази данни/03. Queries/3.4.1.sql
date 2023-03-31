/*
Задача 3.22. Вмъкване на данни
Използвайте базата данни на SoftUni и вмъкнете някои данни, като SQL заявки. 
- towns: Sofia, Plovdiv, Varna, Burgas
- departments: Engineering, Sales, Marketing, Software Development, Quality Assurance
- employees
*/
use `soft_uni`;

insert into `towns` (`town_id`, `name`) values (1,"Sofia");
insert into `towns` (`town_id`, `name`) values (2,"Plovdiv");
insert into `towns` (`town_id`, `name`) values (3,"Varna");
insert into `towns` (`town_id`, `name`) values (4,"Burgas");

insert into `departments` (`department_id`, `name`) values (1,"Engineering");
insert into `departments` (`department_id`, `name`) values (2,"Sales");
insert into `departments` (`department_id`, `name`) values (3,"Marketing");
insert into `departments` (`department_id`, `name`) values (4,"Software Development");
insert into `departments` (`department_id`, `name`) values (5,"Quality Assurance");

insert into `employees` (`first_name`, `middle_name`,`last_name`,`job_title`,`department`,`hire_date`,`salary`)  values ("Ivan","Ivanov","Ivanov",".NET Developer",4,"01/02/2013",3500.00);
insert into `employees` (`first_name`, `middle_name`,`last_name`,`job_title`,`department`,`hire_date`,`salary`)  values ("Petar","Petrov","Petrov","Senior Engineer",1,"02/03/2004",4000.00);
insert into `employees` (`first_name`, `middle_name`,`last_name`,`job_title`,`department`,`hire_date`,`salary`)  values ("Maria","Petrova','Ivanova","Intern",5,"28/08/2016",525.25);
insert into `employees` (`first_name`, `middle_name`,`last_name`,`job_title`,`department`,`hire_date`,`salary`)  values ("Georgi","Terziev","Ivanov","CEO",2,"09/12/2007",3000.00);
insert into `employees` (`first_name`, `middle_name`,`last_name`,`job_title`,`department`,`hire_date`,`salary`)  values ("Peter","Pan","Pan","Intern",3,"28/08/2016",599.88);
