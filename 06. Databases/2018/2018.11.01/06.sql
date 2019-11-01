/* 06. Намерете имейл адреса на всеки служител */
use soft_uni;
select concat(`first_name`,'.',`last_name`,"@softuni.bg")
      as full_email_address 
from employees;