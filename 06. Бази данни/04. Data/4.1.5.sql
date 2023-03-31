/*
Задача 4.5. Последните 7 наети служителя
Напишете заявка, с която да откриете последните 7 наети служителя. Изберете техните собствено и фамилно име и датата, на която са наети. 
*/
use `soft_uni`;
select `first_name`,`last_name`,`hire_date`
from `employees`
order by `hire_date` asc
limit 7;