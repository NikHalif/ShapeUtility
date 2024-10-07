SELECT products.name,
	categories.name
FROM products
	JOIN product_in_category ON product_in_category.product_id = products.id
	JOIN categories ON category.id = products_in_category.category_id
