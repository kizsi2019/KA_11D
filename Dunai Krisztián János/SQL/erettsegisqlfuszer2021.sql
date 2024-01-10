1. feladat
kész

2. feladat

SELECT k.nev, o.nev AS osszetevo_nev
FROM keverek k
JOIN kapcsolat kp ON k.id = kp.keverekid
JOIN osszetevo o ON kp.osszetevoid = o.id;



3. feladat

SELECT nev AS LegdragabbFuszerkeverekNev, 
(ar * 1000 / tomeg) AS KilogrammonkentiAr
FROM keverek
ORDER BY KilogrammonkentiAr DESC
LIMIT 1;



4. feladat

SELECT COUNT(DISTINCT keverekid) AS FuszerekSzama
FROM kapcsolat
WHERE osszetevoid = (SELECT id FROM osszetevo WHERE nev = 'bazsalikom');




5. feladat


SELECT k.nev AS FuszerkeverekNev, COUNT(ko.osszetevoid) AS OsszetevokSzama
FROM keverek AS k
INNER JOIN kapcsolat AS ko ON k.id = ko.keverekid
GROUP BY k.nev
ORDER BY OsszetevokSzama DESC



6. feladat


SELECT k.nev AS FuszerkeverekNev
FROM keverek AS k
WHERE k.id NOT IN (
SELECT ko.keverekid
FROM kapcsolat AS ko
INNER JOIN osszetevo AS o ON ko.osszetevoid = o.id
WHERE o.nev LIKE '%bors'
);



7. feladat

SELECT k.nev
FROM keverek AS k
INNER JOIN kapcsolat AS ko ON k.id = ko.keverekid
INNER JOIN osszetevo AS o ON ko.osszetevoid = o.id
WHERE o.nev = 'paradicsom'
AND k.nev IN (
SELECT k2.nev
FROM keverek AS k2
INNER JOIN kapcsolat AS ko2 ON k2.id = ko2.keverekid
INNER JOIN osszetevo AS o2 ON ko2.osszetevoid = o2.id
WHERE o2.nev = 'chili'
);



8. feladat

SELECT keverek.nev AS FuszerkeverekNev, osszetevo.nev AS Osszetevok
FROM keverek
INNER JOIN kapcsolat ON keverek.id = kapcsolat.keverekid
INNER JOIN osszetevo ON kapcsolat.osszetevoid = osszetevo.id
WHERE keverek.ajanlat LIKE '%indiai%'
ORDER BY keverek.nev, osszetevo.nev;

