1. feladat
INSERT INTO Vetites (azon, mozinev, fkod)
VALUES (356, 'Művész mozi', 2);

2. feladat
UPDATE Filmek
SET hossz = 110
WHERE filmcim = 'Álmodozók';

3. feladat
DELETE FROM Filmek
WHERE filmcim = 'Film';

4. feladat
SELECT filmcim, mufaj, hossz
FROM Filmek;

5. feladat
SELECT filmcim, szarmazas
FROM Filmek
ORDER BY filmcim ASC;

6. feladat
SELECT filmcim, hossz
FROM Filmek
WHERE mufaj = 'dokumentum'
ORDER BY hossz DESC;

7. feladat
SELECT filmcim, hossz
FROM Filmek
WHERE szarmazas = 'amerikai';

8. feladat
SELECT filmcim, mufaj
FROM Filmek
WHERE szinkron = 'mb';


9. feladat
SELECT DISTINCT mozinev
FROM Vetites
ORDER BY mozinev ASC;

10. feladat
SELECT filmcim, szarmazas
FROM Filmek
WHERE szarmazas LIKE '%angol%';

11. feladat
SELECT filmcim, hossz
FROM Filmek
WHERE filmcim LIKE 'B%'

12. feladat
SELECT filmcim, mufaj
FROM Filmek
WHERE hossz >= 90 AND hossz <= 120;

13. feladat
SELECT filmcim, mufaj, hossz
FROM Filmek
ORDER BY hossz DESC
LIMIT 5;

14. feladat
SELECT filmcim, mufaj, hossz
FROM Filmek
ORDER BY hossz ASC
LIMIT 10;
