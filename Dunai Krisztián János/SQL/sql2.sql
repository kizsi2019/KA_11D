SELECT state_province
FROM (
    SELECT ship_state_province AS state_province FROM orders
    UNION ALL
    SELECT state_province FROM customers
) AS merged_states


SELECT category, COUNT(*) AS termek_szam
FROM products
GROUP BY category;


SELECT ship_city, COUNT(*) AS rendeles_szam
FROM orders
GROUP BY ship_city;

SELECT city, COUNT(*) AS ugyfel_szam
FROM customers
GROUP BY city
HAVING COUNT(*) >= 3;
