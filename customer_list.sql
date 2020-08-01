SELECT TOP(20)
    city,
    first_name,
    last_name
FROM
    sales.customers
ORDER BY
    city,
    first_name;