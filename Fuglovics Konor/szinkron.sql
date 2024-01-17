-- 2.
SELECT cim, eredeti, magyarszoveg FROM film WHERE magyarszoveg = "Heltai Olga"

-- 3.
SELECT DISTINCT(rendezo), szinkronrendezo FROM film
WHERE szinkronrendezo != ""
AND ev > 2000

-- 4.
SELECT magyarszoveg, cim FROM film
WHERE rendezo = "Christopher Nolan" AND studio = "Mafilm Audio Kft."

-- 5.
SELECT szinkron.szerep, szinkron.szinesz, szinkron.hang, film.cim
FROM film, szinkron
WHERE szinkron.filmaz = film.filmaz AND hang = "Anger Zsolt"

-- 6.
SELECT film.filmaz, film.cim, film.eredeti, COUNT(szinkron.szinkid)
FROM film, szinkron
WHERE film.filmaz = szinkron.filmaz
GROUP BY film.filmaz

-- 7.
