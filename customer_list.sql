SELECT
    p.product_name,
    p.list_price,
    c.category_name
FROM
    production.products as p
inner join production.categories c 
on c.category_id = p.category_id
ORDER BY
    product_name DESC;