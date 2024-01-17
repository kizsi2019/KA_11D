SELECT cim AS filmcim, eredeti AS eredeticm
FROM film
WHERE magyarszoveg = 'Heltai Olga';

SELECT DISTINCT rendezo AS Filmrendező, szinkronrendezo AS Szinkronrendező
FROM film
WHERE ev > 2000;

SELECT DISTINCT magyarszoveg AS Magyar_szövegíró
FROM film
WHERE rendezo = 'Christopher Nolan' AND studio = 'Mafilm Audio Kft.';

SELECT szerep AS Szerep, szinesz AS Színész, hang AS Hang
FROM szinkron
WHERE hang = 'Anger Zolt';

SELECT f.filmaz, f.cim, COUNT(s.szerep) AS Szinkron_szerepek_száma
FROM film f
JOIN szinkron s ON f.filmaz = s.filmaz
GROUP BY f.filmaz, f.cim;

SELECT szerep AS Szerep, szinesz AS Színész, hang AS Hang
FROM szinkron
WHERE szerep LIKE 'rab%';


SELECT DISTINCT f.rendezo
FROM film f
JOIN szinkron s ON f.filmaz = s.filmaz
WHERE f.rendezo = s.szinesz;


SELECT DISTINCT hang AS Hang
FROM szinkron
WHERE szinesz = 'Pap Kati';

SELECT szinesz AS Színész, hang AS Hang, COUNT(DISTINCT filmaz) AS Filmek_száma
FROM szinkron
GROUP BY szinesz, hang
HAVING COUNT(DISTINCT filmaz) >= 3;

SELECT DISTINCT s.hang
FROM szinkron s
JOIN film f ON s.filmaz = f.filmaz
WHERE f.studio = 'Mafilm Audio Kft.' AND f.ev IN (
    SELECT f2.ev
    FROM film f2
    WHERE f2.studio != 'Mafilm Audio Kft.'
);



