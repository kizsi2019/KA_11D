SELECT nev, terulet FROM alloviz WHERE tipus LIKE '%morotva%';
SELECT nev, tipus, terulet, vizgyujto FROM alloviz WHERE terulet BETWEEN 3 AND 10 AND (vizgyujto / terulet) > 10;
SELECT DISTINCT alloviz.nev, count(telepulesgps.nev) FROM alloviz, helykapcs, telepulesgps
WHERE alloviz.id = helykapcs.allovizid AND telepulesgps.id = helykapcs.gpsid
GROUP BY alloviz.nev HAVING count(telepulesgps.nev) >= 3;
SELECT alloviz.nev, telepulesgps.hosszusag FROM alloviz, helykapcs, telepulesgps WHERE alloviz.id = helykapcs.allovizid AND telepulesgps.id = helykapcs.gpsid ORDER BY MAX(hosszusag)-MIN(hosszusag) DESC LIMIT 1;
SELECT alloviz.nev, terulet, count(telepulesgps.nev) AS darab
FROM alloviz, helykapcs, telepulesgps 
WHERE alloviz.id=allovizid And telepulesgps.id=gpsid 
AND alloviz.terulet IS NOT NULL
GROUP BY alloviz.nev HAVING count(telepulesgps.nev) = 1;
