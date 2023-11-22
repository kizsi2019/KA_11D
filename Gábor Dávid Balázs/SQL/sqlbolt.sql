6. FELADAT

SELECT title, domestic_sales, international_sales 
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

SELECT title, domestic_sales, international_sales 
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

SELECT title, domestic_sales, international_sales 
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;


7. FELADAT

SELECT DISTINCT building FROM employees;

SELECT * FROM buildings;

SELECT DISTINCT building_name, role 
FROM buildings 
LEFT JOIN employees
ON building_name = building;


8. FELADAT

SELECT name, role FROM employees
WHERE building IS NULL;

SELECT DISTINCT building_name
FROM buildings 
LEFT JOIN employees
ON building_name = building
WHERE role IS NULL;


9. FELADAT

SELECT column AS better_column_name, …
FROM a_long_widgets_table_name AS mywidgets
INNER JOIN widget_sales
ON mywidgets.id = widget_sales.widget_id;

SELECT title, rating * 10 AS rating_percent
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

SELECT title, year
FROM movies
WHERE year % 2 = 0;


10. FELADAT

SELECT MAX(years_employed) as Max_years_employed
FROM employees;

SELECT role, AVG(years_employed) as Average_years_employed
FROM employees
GROUP BY role;

SELECT building, SUM(years_employed) as Total_years_employed
FROM employees
GROUP BY building;


11. FELADAT

SELECT role, COUNT(*) as Number_of_artists
FROM employees
WHERE role = "Artist";

SELECT role, COUNT(*)
FROM employees
GROUP BY role;

SELECT role, SUM(years_employed)
FROM employees
GROUP BY role
HAVING role = "Engineer";


12. FELADAT

SELECT director, COUNT(id) as Num_movies_directed
FROM movies
GROUP BY director;

SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
INNER JOIN boxoffice
ON movies.id = boxoffice.movie_id
GROUP BY director;


13. FELADAT

SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
INNER JOIN boxoffice
ON movies.id = boxoffice.movie_id
GROUP BY director;

INSERT INTO boxoffice VALUES (4, 8.7, 340000000, 270000000);


14. FELADAT

UPDATE Movies
SET director = "John Lasseter"
WHERE id = 2;

UPDATE Movies
SET Year = "1999"
WHERE id = 3;

UPDATE movies
SET title = "Toy Story 3", director = "Lee Unkrich"
WHERE id = 11;


15. FELADAT

DELETE FROM Movies
where year < 2005;

DELETE FROM Movies
where director = "Andrew Stanton";


16. FELADAT

CREATE TABLE Database(
    Name TEXT,
    Version FLOAT,
    Download_count INTEGER
);


17. FELADAT

ALTER TABLE Movies
ADD COLUMN Aspect_ratio FLOAT DEFAULT 2.39;

ALTER TABLE Movies
ADD COLUMN Language TEXT DEFAULT English;