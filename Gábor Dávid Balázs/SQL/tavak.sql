2. FELADAT

SELECT nev, terulet
FROM alloviz
WHERE tipus LIKE '%morotva%'
ORDER BY terulet DESC;


3. FELADAT

SELECT SUM(terulet) / 93036 * 100 AS vizarany
FROM alloviz;


4. FELADAT

SELECT nev, tipus, terulet
FROM alloviz
WHERE terulet BETWEEN 3 AND 10
  AND vizgyujto >= 10 * terulet;


5. FELADAT

SELECT alloviz.nev, COUNT(*) AS telepules_szam
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
GROUP BY alloviz.id
HAVING telepules_szam >= 3;


6. FELADAT

SELECT alloviz.nev
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
JOIN telepulesgps ON telepulesgps.id = helykapcs.gpsid
ORDER BY telepulesgps.hosszusag DESC
LIMIT 1;


7. FELADAT

SELECT alloviz.nev, alloviz.terulet, telepulesgps.nev
FROM alloviz
JOIN helykapcs ON alloviz.id = helykapcs.allovizid
JOIN telepulesgps ON telepulesgps.id = helykapcs.gpsid
WHERE (SELECT COUNT(*) FROM helykapcs WHERE alloviz.id = helykapcs.allovizid) = 1
  AND (SELECT COUNT(*) FROM helykapcs WHERE telepulesgps.id = helykapcs.gpsid) = 1;


8. FELADAT

SELECT tipus AS keletkezes_tipusa, nev AS tavi_nev, terulet AS tavi_terulet
FROM alloviz
WHERE tipus IS NOT NULL
ORDER BY keletkezes_tipusa;