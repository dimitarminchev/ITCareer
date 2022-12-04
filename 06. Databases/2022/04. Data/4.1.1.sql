use `soft_uni`;

select `first_name`,`last_name`,`salary`
from `employees`
where `salary` >= 50000
order by `salary` desc;