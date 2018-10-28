/* 261. База данни за онлайн магазин */
CREATE SCHEMA onlineshop;
USE onlineshop;

CREATE TABLE cities(
	city_id INT(11),
    name VARCHAR(50) NOT NULL,
    PRIMARY KEY(city_id)
);

CREATE TABLE customers(
	customer_id INT(11),
	name VARCHAR(50) NOT NULL,
    birthday DATE,
    city_id INT(11),
    PRIMARY KEY(customer_id),
    FOREIGN KEY(city_id) REFERENCES cities(city_id)
);

CREATE TABLE orders(
	order_id INT(11),
    customer_id INT(11),
    PRIMARY KEY(order_id),
    FOREIGN KEY(customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE item_types(
	item_type_id INT(11),
    name VARCHAR(50) NOT NULL,
    PRIMARY KEY(item_type_id)
);

CREATE TABLE items(
	item_id INT(11),
    name VARCHAR(50) NOT NULL,
    item_type_id INT(11),
    PRIMARY KEY(item_id),
    FOREIGN KEY(item_type_id) REFERENCES item_types(item_type_id)
);

CREATE TABLE order_items(
	order_id INT(11),
    item_id INT(11),
    PRIMARY KEY(order_id,item_id),
    FOREIGN KEY(order_id) REFERENCES orders(order_id),
    FOREIGN KEY(item_id) REFERENCES items(item_id)
);