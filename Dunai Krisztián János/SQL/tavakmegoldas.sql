1. feladat
create database tavak;


2. feladat

SELECT nev, terulet
FROM alloviz
WHERE tipus LIKE '%morotva%'
ORDER BY terulet DESC;


3. feladat

SELECT COALESCE(SUM(terulet), 0) / 93036 * 100 AS fedes_arany
FROM alloviz;

vagy 

SELECT SUM(terulet) / 93036 * 100 AS fedes_arany
FROM alloviz
WHERE terulet IS NOT NULL;



4. feladat

SELECT nev, tipus, terulet FROM alloviz
WHERE terulet BETWEEN 3 AND 10 AND vizgyujto >= terulet * 10;


5. feladat

SELECT alloviz.nev AS tónak_a_neve, COUNT(DISTINCT telepulesgps.id) AS hozzátartozó_települések_szama
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
JOIN telepulesgps ON helykapcs.gpsid = telepulesgps.id
GROUP BY alloviz.id, alloviz.nev
HAVING COUNT(DISTINCT telepulesgps.id) >= 3;



6. feladat

SELECT alloviz.nev AS tónak_a_neve
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
JOIN telepulesgps ON helykapcs.gpsid = telepulesgps.id
GROUP BY alloviz.id, alloviz.nev
ORDER BY MAX(telepulesgps.hosszusag) - MIN(telepulesgps.hosszusag) DESC
LIMIT 1;



7. feladat

SELECT alloviz.nev AS tónak_a_neve, alloviz.terulet AS tónak_a_területe, telepulesgps.nev AS hozzátartozó_település_neve
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
JOIN telepulesgps ON helykapcs.gpsid = telepulesgps.id
WHERE
(SELECT COUNT(*) FROM helykapcs AS hkap1 WHERE hkap1.allovizid = alloviz.id) = 1
AND 
(SELECT COUNT(*) FROM helykapcs AS hkap2 WHERE hkap2.gpsid = telepulesgps.id) = 1;


8. feladat

SELECT alloviz.nev AS "Tónak a neve", alloviz.terulet AS "Tó területe (km2)"
FROM alloviz
WHERE alloviz.tipus IS NOT NULL
ORDER BY alloviz.tipus;



