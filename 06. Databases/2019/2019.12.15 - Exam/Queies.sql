-- Step 4. Queies

# Заявка 1: Всички растения
USE plant_service;
SELECT id,name,price FROM plants
WHERE quantity > 10 AND price > 15
ORDER BY price DESC, name ASC
LIMIT 30; 

# Заявка 2: Потребители без фамилия
USE plant_service;
SELECT id, username, first_name, age, 
CONCAT(DAY(register_date),"-",MONTH(register_date)) AS register_day_month 
FROM users
WHERE last_name IS NULL AND age < 60
ORDER BY age ASC, username ASC;

# Заявка 3: Растения от семейство
USE plant_service;
SELECT plants.id,plants.name,info_plants.family,info_plants.genus
FROM plants, info_plants
WHERE plants.id=info_plants.plant_id AND quantity > 0 AND family="Poaceae"
ORDER BY genus ASC, name ASC;

# Заявка 4: Потребители без поръчки
USE plant_service;
SELECT IF(users.last_name IS NULL, users.first_name, CONCAT(users.first_name,' ',users.last_name)) AS `full_name`,
users.username,cities.name as city,YEAR(users.register_date) AS register_year
FROM users, cities
WHERE users.city_id=cities.id AND users.id NOT IN (SELECT user_id FROM orders) 
ORDER BY register_year ASC, `full_name` ASC;

# Заявка 5: Получени поръчки
USE plant_service;
SELECT users.id, CONCAT(users.first_name) as `first_name`, users.age, COUNT(orders.id) AS received_orders
FROM users, orders
WHERE users.id=orders.user_id AND is_completed=1
GROUP BY users.id
ORDER BY received_orders DESC, `first_name` ASC
LIMIT 10;

# Заявка 6: Поръчки по държави
USE plant_service;
SELECT query.name AS country_name, SUM(query.total) AS total_sum, COUNT(query.total) AS count_orders
FROM
(
	SELECT cities.country_name as name, plants.price as total
	FROM plants, plants_orders, orders, users, cities
	WHERE 
		plants.id = plants_orders.plant_id AND
		plants_orders.order_id = orders.id AND 
		orders.user_id = users.id AND 
		users.city_id = cities.id 
) AS query
GROUP BY query.name
ORDER BY total_sum DESC, count_orders DESC;

# Заявка 7: Поръчки от род
USE plant_service;
SELECT users.id, users.first_name, COUNT(orders.id) AS `orders`
FROM users, orders
WHERE users.id = orders.user_id AND users.id IN
(
	SELECT user_id FROM orders
	WHERE id IN
	(
		SELECT order_id FROM plants_orders
		LEFT JOIN info_plants ON info_plants.plant_id = plants_orders.plant_id 
		WHERE info_plants.genus = "Begonia"
	)
)
GROUP BY users.id
ORDER BY `orders` DESC, `first_name` ASC;


	