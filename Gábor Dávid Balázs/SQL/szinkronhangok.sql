2. feladat

SELECT film.cim, film.eredeti
FROM film
WHERE film.magyarszoveg = "Heltai Olga"


3. feladat

SELECT DISTINCT film.rendezo, film.szinkronrendezo
FROM film 
WHERE ev > 2000


4. feladat

SELECT film.magyarszoveg, film.cim
FROM film
WHERE film.rendezo = "Christopher Nolan" and film.studio = "Mafilm Audio Kft."
ORDER BY film.magyarszoveg


5. feladat

SELECT film.cim, szinkron.szerep, szinkron.szinesz, film.eredeti
FROM film, szinkron
WHERE film.filmaz = szinkron.filmaz and szinkron.hang = "Anger Zsolt"


6. feladat

SELECT film.eredeti, film.cim, count(szinkron.szinkid)
FROM film, szinkron
WHERE film.filmaz = szinkron.filmaz
GROUP BY film.eredeti


7. feladat

SELECT szinkron.szerep, szinkron.szinesz, szinkron.hang
FROM szinkron
WHERE szinkron.szerep LIKE "%rab%" or szinkron.szerep LIKE "rab%";


8. feladat

SELECT DISTINCT film.rendezo AS "Színész-rendező"
FROM film, szinkron
WHERE film.rendezo = szinkron.szinesz


9. feladat

SELECT film.cim, szinkron.hang
FROM film, szinkron
WHERE film.filmaz = szinkron.filmaz
AND szinkron.filmaz IN (
  SELECT szinkron.filmaz
  FROM szinkron
  WHERE szinkron.hang = "Pap Kati"
)
AND szinkron.hang <> "Pap Kati"
ORDER BY film.cim, szinkron.hang;


10. feladat

SELECT szinkron.szinesz, szinkron.hang, count(szinkron.szinkid) AS FilmDB
FROM szinkron
GROUP BY szinkron.szinesz, szinkron.hang
HAVING count(szinkron.szinkid) >= 3
ORDER BY FilmDB DESC;


11. FELADAT

SELECT S1.hang, F1.ev, F1.studio, F1.cim, S2.hang, F2.ev, F2.studio, F2.cim
FROM szinkron S1, szinkron S2, film F1, film F2
WHERE F1.filmaz = S1.filmaz AND F2.filmaz = S2.filmaz
AND S1.hang = S2.hang
AND F1.studio = "Mafilm Audio Kft." AND F2.studio <> "Mafilm Audio Kft."
AND F1.ev = F2.ev
ORDER BY S1.hang;  