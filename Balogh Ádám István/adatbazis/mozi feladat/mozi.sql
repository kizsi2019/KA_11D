1., INSERT INTO vetites (azon, fkod, mozinev) VALUES (356, 2, 'Művész');

2., UPDATE Filmek SET hossz = 110 WHERE filmcim = 'Álmodozók';

3., DELETE FROM Filmek WHERE filmcim = 'Film';

4., SELECT filmcim, mufaj, hossz FROM Filmek;

5., SELECT filmcim, szarmazas FROM Filmek ORDER BY filmcim ASC;

6., SELECT filmcim, hossz FROM Filmek WHERE mufaj = 'dokumentumfilm'ORDER BY hossz DESC;

7., SELECT filmcim, hossz FROM Filmek WHERE szarmazas = 'amerikai';

8., SELECT filmcim, mufaj FROM Filmek WHERE szinkron = 'mb' AND szarmazas = 'magyar';

9., SELECT DISTINCT mozinev FROM Vetites ORDER BY mozinev ASC;

10., SELECT filmcim, szarmazas FROM Filmek WHERE szarmazas LIKE '%angol%';

11., SELECT filmcim, hossz FROM Filmek WHERE filmcim LIKE 'B%' ORDER BY hossz ASC;

12., SELECT filmcim, mufaj FROM Filmek ORDER BY hossz DESC LIMIT 5;

13., SELECT filmcim, mufaj FROM Filmek ORDER BY hossz DESC LIMIT 5;

14., SELECT filmcim, mufaj FROM Filmek ORDER BY hossz ASC LIMIT 10;
