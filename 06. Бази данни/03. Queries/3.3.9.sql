/*
Задача 3.9. Намерете имената на всички служители
Напишете SQL заявка, която намира пълното име на всички служители, чиято заплата е 25000, 14000, 12500 или 23600. Пълното име е комбинация от личното, бащиното и фамилното име (разделени с единичен интервал) и те трябва да бъдат в една колона, наречена "Пълно име" “Full Name”. Изпратете вашите заявки като Подготвите БД & изпълните заявките (Prepare DB & run queries.) 
*/
SELECT concat(`first_name`," ",`middle_name`," ",`last_name`) AS "full_name"
FROM `soft_uni`.`employees`
WHERE `salary` in (25000, 14000, 12500, 23600);