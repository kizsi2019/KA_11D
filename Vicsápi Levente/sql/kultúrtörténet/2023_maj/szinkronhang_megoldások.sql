SELECT cim, eredeti FROM film WHERE magyarszoveg = 'Heltai Olga'
SELECT DISTINCT rendezo, szinkronrendezo FROM film WHERE ev > 2000;
SELECT DISTINCT magyarszoveg, studio FROM film WHERE studio = 'Mafilm Audio Kft.' AND rendezo = 'Christopher Nolan' ORDER BY magyarszoveg;
SELECT film.cim, szinkron.szerep FROM film
JOIN szinkron
ON film.filmaz = szinkron.filmaz WHERE szinkron.hang = 'Anger Zsolt';
SELECT cim, eredeti, count(hang) as szinkron FROM film
JOIN szinkron
ON film.filmaz = szinkron.filmaz GROUP BY cim;
SELECT szerep, szinesz, hang FROM szinkron WHERE szerep LIKE '%rab%';
SELECT DISTINCT film.rendezo as 'Színész-rendező' FROM film
JOIN szinkron 
ON film.filmaz = szinkron.filmaz WHERE film.rendezo = szinkron.szinesz;
SELECT szinkron.szinesz, szinkron.hang, count(film.cim) as darab FROM film
JOIN szinkron
ON film.filmaz = szinkron.filmaz GROUP BY szinkron.szinesz HAVING count(film.cim) >= 3
ORDER BY count(film.cim) DESC;
