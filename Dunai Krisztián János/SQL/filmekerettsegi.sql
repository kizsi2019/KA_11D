2. feladat


SELECT cim, eredeti
FROM film
WHERE magyarszoveg = 'Heltai Olga';


3. feladat

SELECT DISTINCT film.rendezo, film.szinkronrendezo
FROM film
WHERE film.ev > 2000;


4. feladat

SELECT film.magyarszoveg, film.cim from film
WHERE film.rendezo = "Christopher Nolan" and film.studio = "Mafilm Audio Kft."
ORDER BY film.magyarszoveg;


5. feladat

SELECT film.cim AS magyarcim, film.eredeti AS eredeticim, szinkron.szinesz AS szinesz, szinkron.szerep AS szineszszerepe FROM film 
JOIN szinkron ON film.filmaz = szinkron.filmaz
WHERE szinkron.hang = 'Anger Zsolt';


6. feladat

SELECT fm.eredeti, fm.cim, COUNT(szp.szerep) as szerepek_szama FROM film fm
JOIN szinkron szp ON fm.filmaz = szp.filmaz
GROUP BY fm.filmaz
ORDER BY fm.eredeti;


7. feladat

SELECT szinkron.szerep, szinkron.szinesz, szinkron.hang FROM szinkron
WHERE szinkron.szerep LIKE 'rab%';


8. feladat

SELECT DISTINCT rendezo AS 'Színész-rendező' FROM film
WHERE rendezo IN (SELECT szinesz FROM szinkron);


9. feladat

SELECT DISTINCT foszinkron.hang, filmek.cim FROM szinkron AS foszinkron
JOIN szinkron AS masodikszinkron ON foszinkron.filmaz = masodikszinkron.filmaz AND foszinkron.szinkid != masodikszinkron.szinkid
JOIN film AS filmek ON foszinkron.filmaz = foszinkron.filmaz
WHERE masodikszinkron.hang = 'Pap Kati' AND foszinkron.hang != 'Pap Kati'
ORDER BY filmek.cim ASC, foszinkron.hang ASC;


10. feladat

SELECT szink.szinesz AS Filmszinesz, szink.hang AS Szinkronszinesz, COUNT(szink.filmaz) AS filmszamok FROM szinkron AS szink
GROUP BY szink.szinesz, szink.hang
HAVING COUNT(szink.filmaz) >= 3
ORDER BY filmszamok DESC;

11. feladat

SELECT szink.hang AS szinkszinesz, filmek.ev AS Ev FROM szinkron AS szink
JOIN film AS filmek ON szink.filmaz = filmek.filmaz
WHERE filmek.studio = 'Mafilm Audio Kft.' OR filmek.studio != 'Mafilm Audio Kft.'
GROUP BY szink.hang, filmek.ev HAVING COUNT(DISTINCT filmek.studio) > 1
ORDER BY szink.hang ASC;



