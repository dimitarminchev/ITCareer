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