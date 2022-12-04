use `soft_uni`;

select *
from `employees`
order by 
	`salary` desc, 
	`first_name` asc, 
	`last_name` desc, 
    `middle_name` asc;