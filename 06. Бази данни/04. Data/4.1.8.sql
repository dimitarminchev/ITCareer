/*
Задача 4.8. Държави и валути (Евро / Не евро)
Намерете всички държави заедно с информация за тяхната валута. Покажете името на държавата, нейният код и информация за нейната валута: или "Евро", или "Не евро". Сортирайте резултатите по име на страната по азбучен ред. 
*/
use `geography`;
select `country_name`,`country_code`,
if(`currency_code`="EUR","Euro","Not Euro") as 'currency'
from `countries`
order by `country_name` asc;