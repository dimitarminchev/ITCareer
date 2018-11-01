/* 23. Вмъкване на данни */
USE soft_uni;

/* towns */
INSERT INTO towns(`name`) VALUE ("Sofia");
INSERT INTO towns(`name`) VALUE ("Plovdiv");
INSERT INTO towns(`name`) VALUE ("Varna");
INSERT INTO towns(`name`) VALUE ("Burgas");

/* departments */
INSERT INTO departments(`name`) VALUE ("Engineering");
INSERT INTO departments(`name`) VALUE ("Sales");
INSERT INTO departments(`name`) VALUE ("Marketing");
INSERT INTO departments(`name`) VALUE ("Software Development");
INSERT INTO departments(`name`) VALUE ("Quality Assurance"); 

/* employees */
INSERT INTO employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
VALUE ("Ivan","Ivanov","Ivanov",".NET Developer", 
(SELECT department_id as id FROM departments WHERE name="Software Development" ORDER by ID DESC LIMIT 1),
"2013-02-01","3500.00");

INSERT INTO employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
VALUE ("Petar","Petrov","Petrov","Senior Engineer",
(SELECT department_id as id FROM departments WHERE name="Engineering" ORDER by ID DESC LIMIT 1),
"2004-03-02","4000.00");

INSERT INTO employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
VALUE ("Maria","Petrova","Ivanova","Intern",
(SELECT department_id as id FROM departments WHERE name="Quality Assurance" ORDER by ID DESC LIMIT 1),
"2016-08-28","525.25");

INSERT INTO employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
VALUE ("Georgi","Terziev","Ivanov","CEO",
(SELECT department_id as id FROM departments WHERE name="Sales" ORDER by ID DESC LIMIT 1),
"2007-12-09","3000.00");

INSERT INTO employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
VALUE ("Peter","Pan","Pan","Intern",
(SELECT department_id as id FROM departments WHERE name="Marketing" ORDER by ID DESC LIMIT 1),
"2016-08-23","599.88");		
