/* 25. Основно избиране на няколко полета */
SELECT 
towns.name, /* tows */
departments.name, /* departments */
first_name, last_name, job_title, salary /* employees */

FROM towns,departments,employees,addresses

WHERE  employees.address_id = addresses.address_id AND 
       addresses.town_id = towns.town_id AND
       employees.department_id = departments.department_id
