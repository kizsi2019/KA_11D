1. FELADAT

SELECT fuszer.nev, tevo.nev AS osszetevo_nev
FROM keverek fuszer
JOIN kapcsolat kp ON fuszer.id = kp.keverekid
JOIN osszetevo tevo ON kp.osszetevoid = tevo.id;


2. FELADAT

SELECT nev AS legdragabbfuszernev, 
(ar * 1000 / tomeg) AS arkilogrammonkent
FROM keverek
ORDER BY arkilogrammonkent DESC
LIMIT 1;


3.FELADAT

SELECT COUNT(DISTINCT keverekid) AS fuszerszam
FROM kapcsolat
WHERE osszetevoid = (SELECT id FROM osszetevo WHERE nev = 'bazsalikom');


4. FELADAT

SELECT k.nev AS FuszerkeverekNev, COUNT(ko.osszetevoid) AS OsszetevokSzama
FROM keverek AS k
INNER JOIN kapcsolat AS ko ON k.id = ko.keverekid
GROUP BY k.nev
ORDER BY OsszetevokSzama DESC


5. FELADAT

SELECT fuszerek.nev AS fuszernev
FROM keverek AS fuszerek
WHERE fuszerek.id NOT IN (
SELECT ko.keverekid
FROM kapcsolat AS ko
INNER JOIN osszetevo AS o ON ko.osszetevoid = o.id
WHERE o.nev LIKE '%bors'
);


6. FELADAT

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


7. FELADAT

SELECT keverek.nev AS fuszernev, osszetevo.nev AS Osszetevok
FROM keverek
INNER JOIN kapcsolat ON keverek.id = kapcsolat.keverekid
INNER JOIN osszetevo ON kapcsolat.osszetevoid = osszetevo.id
WHERE keverek.ajanlat LIKE '%indiai%'
ORDER BY keverek.nev, osszetevo.nev;