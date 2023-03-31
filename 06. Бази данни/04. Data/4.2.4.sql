/*
Задача 4.12. Служителите от San Francisco
Напишете заявка, която показва имената на всички служители, живеещи в град San Francisco
*/
use `soft_uni`;
select `employee_id`, concat(`first_name`," ",`last_name`) as 'employee_name'
from `employees`
where `address_id` in
(
	select `address_id`
	from `addresses`
	where `town_id` = 
	(
		select `town_id`
		from `towns`
		where `name` = "San Francisco"
	)
);