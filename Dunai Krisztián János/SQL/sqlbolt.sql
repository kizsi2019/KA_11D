6. feladat
6.1 
SELECT title, domestic_sales, international_sales 
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

6.2 
SELECT title, domestic_sales, international_sales
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id
WHERE international_sales > domestic_sales;

6.3 
SELECT title, rating
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id
ORDER BY rating DESC;

7. feladat
7.1 
SELECT DISTINCT building FROM employees;

7.2
SELECT * FROM buildings;

7.3
SELECT DISTINCT building_name, role 
FROM buildings 
LEFT JOIN employees
ON building_name = building;

8. feladat
8.1 
SELECT name, role FROM employees
WHERE building IS NULL;

8.2 
SELECT DISTINCT building_name
FROM buildings 
LEFT JOIN employees
ON building_name = building
WHERE role IS NULL;

9. feladat
9.1
SELECT title, (domestic_sales + international_sales) / 1000000 AS gross_sales_millions
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

9.2
SELECT title, rating * 10 AS rating_percent
FROM movies
JOIN boxoffice
ON movies.id = boxoffice.movie_id;

9.3
SELECT title, year
FROM movies
WHERE year % 2 = 0;

10. feladat
10.1
SELECT MAX(years_employed) as Max_years_employed
FROM employees;

10.2
SELECT role, AVG(years_employed) as Average_years_employed
FROM employees
GROUP BY role;

10.3
SELECT building, SUM(years_employed) as Total_years_employed
FROM employees
GROUP BY building;

11. feladat
11.1
SELECT role, COUNT(*) as Number_of_artists
FROM employees
WHERE role = "Artist";

11.2
SELECT role, COUNT(*)
FROM employees
GROUP BY role;

11.3
SELECT role, SUM(years_employed)
FROM employees
GROUP BY role
HAVING role = "Engineer";

12. feladat
12.1
SELECT director, COUNT(id) as Num_movies_directed
FROM movies
GROUP BY director;

12.2
SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
INNER JOIN boxoffice
ON movies.id = boxoffice.movie_id
GROUP BY director;

13. feladat
13.1 
INSERT INTO movies VALUES (4, "Toy Story 4", "El Directore", 2015, 90);

13.2
INSERT INTO boxoffice VALUES (4, 8.7, 340000000, 270000000);

14. feladat
14.1
UPDATE movies
SET director = "John Lasseter"
WHERE id = 2;

14.2
UPDATE movies
SET year = 1999
WHERE id = 3;

14.3
UPDATE movies
SET title = "Toy Story 3", director = "Lee Unkrich"
WHERE id = 11;

15. feladat
15.1
DELETE FROM movies
where year < 2005;

15.2
DELETE FROM movies
where director = "Andrew Stanton";

16. feladat
16.1
CREATE TABLE Database (
Name TEXT,
Version FLOAT,
Download_count INTEGER
);

17. feladat
17.1
ALTER TABLE Movies
ADD COLUMN Aspect_ratio float default 2.38;

17.2
ALTER TABLE Movies
ADD COLUMN Language TEXT DEFAULT "English";

18. feladat
18.1
DROP TABLE Movies;

18.2
DROP TABLE BoxOffice;

