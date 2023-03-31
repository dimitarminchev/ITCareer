/*
Задача 4.6. Всички планински върхове
Покажете всички планински върхове, подредени по азбучен ред. 
*/
use `geography`;
select `peak_name`
from `peaks`
order by `peak_name`;