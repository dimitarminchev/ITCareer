/*
Задача 4.9. Най-ниско платени служители
Напишете заявка, с която да намерите имената и заплатите на служителите, които получават най-ниски заплати в компанията. 
*/
use `soft_uni`;
select `first_name`,`last_name`,`salary`
from `employees`
where `salary` =  
(
	select `salary`
    from `employees`
    order by `salary` asc
	limit 1
);