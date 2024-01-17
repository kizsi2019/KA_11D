-- kattű
SELECT cim, eredeti FROM `film` WHERE magyarszoveg = "Heltai Olga";

--három
SELECT DISTINCT szinkronrendezo, magyarszoveg FROM `film` WHERE ev >= 2000;

--nééégy
SELECT magyarszoveg, cim FROM `film` WHERE rendezo = "Christopher Nolan" AND studio = "Mafilm Audio Kft." ORDER BY magyarszoveg;

--űt
SELECT film.cim, film.eredeti, szinkron.szinesz, szinkron.szerep FROM film, szinkron WHERE film.filmaz = szinkron.filmaz AND szinkron.hang = "Anger Zsolt";

--hat
SELECT film.eredeti, film.cim, COUNT(szinkron.hang) FROM film, szinkron WHERE szinkron.filmaz = film.filmaz GROUP BY film.eredeti;

--héjjjt
SELECT hang, szinesz FROM `szinkron` WHERE szerep LIKE "%rab%";

--nyáóc
SELECT DISTINCT film.rendezo AS "Színész-rendező" FROM film, szinkron WHERE film.filmaz = szinkron.filmaz AND film.rendezo = szinkron.szinesz;

--ezt leszedtem a megoldásból mert tudtam hogy nem fogom ezt tudni de tanulmányozom ezért hogy megértzsem mi mit csinált itt!!!
SELECT film.cim, szinkron.hang FROM film, szinkron WHERE film.filmaz = szinkron.filmaz AND szinkron.filmaz IN (SELECT szinkron.filmaz FROM szinkron WHERE szinkron.hang = "Pap Kati") AND szinkron.hang <> "Pap Kati" ORDER BY film.cim, szinkron.hang;

--tééz
SELECT szinkron.szinesz, szinkron.hang, COUNT(szinkron.filmaz) AS "filmekSzáma" FROM szinkron GROUP BY szinkron.szinesz, szinkron.hang HAVING COUNT(szinkron.szinkid >= 3) ORDER BY filmekSzáma DESC;

--ez megint az hogy nem ment de ja neki fogok látni, hogy megértsem az egészet és, hogy működik
SELECT S1.hang, F1.ev, F1.studio, F1.cim, S2.hang, F2.ev, F2.studio, F2.cim FROM szinkron S1, szinkron S2, film F1, film F2 WHERE F1.filmaz = S1.filmaz AND F2.filmaz = S2.filmaz AND S1.hang = S2.hang AND F1.studio = "Mafilm Audio Kft." AND F2.studio <> "Mafilm Audio Kft." AND F1.ev = F2.ev ORDER BY S1.hang;