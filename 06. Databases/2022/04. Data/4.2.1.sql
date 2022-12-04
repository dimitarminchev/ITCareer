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