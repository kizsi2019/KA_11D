Gábor Dávid

1. FELADAT

INSERT INTO vetites (fkod, mozinev, azon)
VALUES (2, 'Művész moziban', 356);


2. FELADAT

UPDATE filmek
SET hossz = 110
WHERE filmcim = 'Álmodozók';


3. FELADAT

DELETE FROM filmek
WHERE filmcim = 'Film';


4. FELADAT

SELECT filmcim, mufaj, hossz
FROM filmek;


5. FELADAT

SELECT filmcim, szarmazas
FROM filmek
ORDER BY filmcim ASC;


6. FELADAT

SELECT filmcim, hossz
FROM filmek
WHERE mufaj = 'dokumentum'
ORDER BY hossz DESC;


7. FELADAT

SELECT filmcim, hossz
FROM filmek
WHERE szarmazas = 'amerikai';


8. FELADAT

SELECT filmcim, mufaj
FROM filmek
WHERE szarmazas = 'magyar';


9. FELADAT

SELECT DISTINCT mozinev
FROM Vetites
ORDER BY mozinev ASC;


10. FELADAT

SELECT filmcim, mufaj
FROM filmek
WHERE szarmazas = 'amerikai-angol';


11. FELADAT

SELECT filmcim, hossz
FROM filmek
WHERE filmcim LIKE 'B%';


12. FELADAT

SELECT filmcim, mufaj
FROM filmek
WHERE hossz BETWEEN 90 AND 120;


13. FELADAT

SELECT filmcim, mufaj
FROM filmek
ORDER BY hossz DESC
LIMIT 5;


14. FELADAT

SELECT filmcim, mufaj
FROM filmek
ORDER BY hossz ASC
LIMIT 10;
