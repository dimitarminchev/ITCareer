/* 
Задача 6.9. Възрастови групи
Напишете заявка, която създава 7 различни групи според тяхната възраст.
*/
USE `gringotts`;
(
	select "[0-10]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 0 and 10 
)
union
(
	select "[11-20]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 11 and 20
)
union
(
	select "[21-30]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 21 and 30
)
union
(
	select "[31-40]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 31 and 40
)
union
(
	select "[41-50]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 41 and 50
)
union
(
	select "[51-60]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` between 51 and 60
)
union
(
	select "[61+]" as `age_group`, count(*) as `wizard_count`
	from `wizzard_deposits`
	where `age` > 60
);