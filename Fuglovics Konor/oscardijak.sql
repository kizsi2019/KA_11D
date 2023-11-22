-- 2.
SELECT nyert, ev, cim FROM film WHERE nyert = "1"
ORDER BY ev ASC

-- 3.
SELECT ev FROM film
GROUP BY ev HAVING COUNT(id)>=10

-- 4.
SELECT ev, cim FROM film where bemutato BETWEEN "1939-01-01" AND "1945-01-01"

-- 5.
SELECT cim FROM film WHERE bemutato - ev...

-- 6.
SELECT nev, MAX(ev)-MIN(ev) AS eltelt, COUNT(film.id) FROM film, keszito, kapcsolat WHERE film.id=kapcsolat.filmid AND keszito.id=kapcsolat.keszitoid AND producer...

-- 8.
SELECT keszito.nev FROM keszitoWHERE keszito.id NOT IN
	(SELECT kapcsolat.keszitoid
	FROM kapcsolat, film
	WHERE kapcsolat.filmid=film.id
	AND film.bemutato IS NOT NULL) AND keszito.producer;
