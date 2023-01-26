# Figure
Библиотека для работы с фигурами геометрии


В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT product, categories FROM table
если таблицы разные
SELECT product, category
FROM products
LEFT OUTER JOIN categories
ON product.product_id=category.product_id;
