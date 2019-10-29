/* 25. Основно избиране на няколко полета */
USE soft_uni;

/* Избор на колони */
SELECT 
towns.name as town, /* tows */
departments.name as department, /* departments */
first_name, last_name, job_title, salary /* employees */

/* Таблици: градове, департаменти и работници */
FROM towns,departments,employees,addresses

/* Описване на връзките */
WHERE  employees.address_id = addresses.address_id AND 
       addresses.town_id = towns.town_id AND
       employees.department_id = departments.department_id
