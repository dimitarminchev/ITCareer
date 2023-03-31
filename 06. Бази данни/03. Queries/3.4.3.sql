/*
Задача 3.24. Основно избиране на няколко полета
Променете  заявките от предишните задачи за да се показват само някои от колоните. За таблица: 
- towns – name
- department –name
- employees – first_name, last_name, job_title, salary
Запазете подредбата от предишната задача. Изпратете заявката си до системата за проверка като стартирате заявките и проверите базата от данни ( Run queries & check DB).
*/
use `soft_uni`;

select `name` from `towns`;

select `name` from `departments`;

select `first_name`, `last_name`, `job_title`, `salary` from `employees`; 
