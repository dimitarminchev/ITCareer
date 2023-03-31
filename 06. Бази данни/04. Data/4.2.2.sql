/*
Задача 4.10. Служители с близки до най-ниските заплати
Напишете заявка, с която да намерите имената и заплатите на служителите (общо 35) с заплати до 10% по-високи от най-ниските в компанията. 
*/
use `soft_uni`;
select `first_name`,`last_name`,`salary`
from `employees`
where `salary` BETWEEN  
(
	select `salary`
    from `employees`
    order by `salary` asc
	limit 1
) 
AND
(
	select (`salary`*1.10) as 'salary'
    from `employees`
    order by `salary` asc
	limit 1
)
order by `salary` asc;