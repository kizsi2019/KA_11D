6.1
SELECT title, rating
FROM movies
  JOIN boxoffice
    ON movies.id = boxoffice.movie_id
ORDER BY rating DESC;

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
7.1
SELECT DISTINCT building FROM employees;
7.2
SELECT building_name, capacity FROM buildings;
7.3
SELECT DISTINCT building_name, role 
FROM buildings 
  LEFT JOIN employees
    ON building_name = building;
8.1
SELECT name, role FROM employees
WHERE building IS NULL;
8.2
SELECT DISTINCT building_name
FROM buildings 
  LEFT JOIN employees
    ON building_name = building
WHERE role IS NULL;
9.1
SELECT title, (domestic_sales + international_sales) / 1000000 AS gross_sales_millions
FROM movies
  JOIN boxoffice
    ON movies.id = boxoffice.movie_id;
9.2
SELECT title, rating *10
FROM movies
  JOIN boxoffice
    ON Movies.id = boxoffice.movie_id;
9.3
SELECT title, rating *10
FROM movies
  JOIN boxoffice
    ON Movies.id = boxoffice.movie_id;
10.1
SELECT MAX(years_employed) as Max_years_employed
FROM employees;
10.2
SELECT role, AVG(years_employed) as Average_years_employed
FROM employees
GROUP BY role;
10.3
SELECT building, sum(years_employed) as Average_years_employed
FROM employees
GROUP BY building;
11.1
SELECT role, COUNT(*) as Number_of_artists
FROM employees
WHERE role = "Artist";
11.2
SELECT role, COUNT(*)
FROM employees
group by role;
11.3
SELECT role, COUNT(*)
FROM employees
group by role;
12.1
SELECT role, COUNT(*)
FROM employees
group by role;
12.2
SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
    INNER JOIN boxoffice
        ON movies.id = boxoffice.movie_id
GROUP BY director;
13.1
SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
    INNER JOIN boxoffice
        ON movies.id = boxoffice.movie_id
GROUP BY director;
13.2
SELECT director, SUM(domestic_sales + international_sales) as Cumulative_sales_from_all_movies
FROM movies
    INNER JOIN boxoffice
        ON movies.id = boxoffice.movie_id
GROUP BY director;
14.1
UPDATE movies
SET director = "John Lasseter"
WHERE id = 2;
14.2
UPDATE movies
SET year = "1999"
where id = 3
14.3
UPDATE movies
SET title = "Toy Story 3", director = "Lee Unkrich"
WHERE id = 11;
15.1
delete from movies
where year < 2005
15.2
delete from movies
where director = "Andrew Stanton"
16.1
CREATE TABLE Database (
    Name TEXT,
    Version FLOAT,
    Download_count INTEGER
);
17.1
ALTER TABLE Movies
  ADD COLUMN Aspect_ratio FLOAT DEFAULT 2.39;
17.2
ALTER TABLE Movies
  ADD COLUMN Language TEXT DEFAULT "English";
18.1
drop table if exists movies
18.2
drop table if exists boxoffice