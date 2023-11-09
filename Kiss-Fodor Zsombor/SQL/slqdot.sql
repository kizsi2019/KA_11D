SELECT DISTINCT building FROM employees;
SELECT building_name,capacity FROM buildings ;
SELECT DISTINCT building_name, role FROM buildings LEFT JOIN employees ON building_name = building;
SELECT name, role FROM employees WHERE building IS NULL;
SELECT DISTINCT building_name FROM buildings LEFT JOIN employees ON building_name = building WHERE building IS NULL;
SELECT title, (domestic_sales + international_sales) / 1000000 AS gross_sales_millions FROM movies JOIN boxoffice ON movies.id = boxoffice.movie_id; //joinban volt bajom lol
SELECT title, rating * 10 AS ratings FROM movies JOIN boxoffice ON movies.id = boxoffice.movie_id; 
SELECT title, year FROM movies WHERE year % 2 = 0;
SELECT MAX(years_employed) FROM employees;
SELECT role, AVG(years_employed) as Average_years_employed FROM employees GROUP BY role; //group by-t hagytam ki
SELECT building, SUM(years_employed) as Total_years_employed FROM employees GROUP BY building; //itt a buidling-et az elejéröl hagytam ki
SELECT role, COUNT(*) as Number_of_artists FROM employees WHERE role = "Artist";
SELECT role, COUNT(*) as Number_of_artists FROM employees GROUP BY role;
SELECT SUM(years_employed), role FROM employees WHERE role = "Engineer";
SELECT COUNT(title), director FROM movies GROUP BY director;
SELECT director, SUM(domestic_sales + international_sales) as total_sales FROM movies JOIN boxoffice ON movies.id = boxoffice.movie_id GROUP BY director;
INSERT INTO movies VALUES (4, "Toy Story 4", "John Biden", 2023, 100);
INSERT INTO boxoffice VALUES (4, 8.7, 340000000, 270000000);
UPDATE movies SET Director = "John Lasseter" WHERE Id = 2;
UPDATE movies SET year = 1999 WHERE title = "Toy Story 2";
UPDATE movies SET title ="Toy Story 3", Director = "Lee Unkrich" WHERE title = "Toy Story 8";
DELETE FROM Movies WHERE year <= 2005;
DELETE FROM Movies WHERE director = "Andrew Stanton";
CREATE TABLE Database (Name TEXT, Version FLOAT, Download_count INTEGER);
ALTER TABLE Movies ADD COLUMN Aspect_ratio FLOAT DEFAULT 4.1;
ALTER TABLE Movies ADD COLUMN Language TEXT DEFAULT "English";
DROP TABLE IF EXISTS Movies;
DROP TABLE IF EXISTS boxoffice;