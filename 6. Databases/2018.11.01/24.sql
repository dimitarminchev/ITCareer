/* 24. Основно избиране на всички полета */
USE soft_uni;

/* Данни от три таблици */
SELECT towns.*, departments.*, employees.*

/* Таблици: градове, департаменти и работници */
FROM towns,departments,employees,addresses

/* Описване на връзките */
WHERE  employees.address_id = addresses.address_id AND 
       addresses.town_id = towns.town_id AND
       employees.department_id = departments.department_id