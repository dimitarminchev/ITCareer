/*
Задача 4.11. Всички мениджъри
Напишете заявка, която показва името, фамилията и длъжността на всички мениджъри в компанията, сортирани по име и фамилия.
*/
use `soft_uni`;
select `first_name`,`last_name`,`job_title`
from `employees`
where `employee_id` in
(
	select distinct `manager_id`
    from `employees`
    where `manager_id` is not null
)
order by `first_name`,`last_name`;