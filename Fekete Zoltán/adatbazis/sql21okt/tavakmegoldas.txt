2morotva,
SELECT nev,terulet FROM `alloviz` WHERE tipus='morotvató'
ORDER BY terulet DESC;

3vizarany,
SELECT (SUM(terulet) / 93036) * 100 FROM alloviz

4kozepes,
SELECT nev,tipus,terulet FROM `alloviz` WHERE terulet BETWEEN 3 AND 10 AND vizgyujto>=10*terulet

5sok,
SELECT nev, Count(gpsid) as Darab
FROM alloviz,helykapcs
WHERE id=allovizid
GROUP BY id,nev
HAVING Count(gpsid)>=3;

6keletnyugat,
SELECT TOP 1 alloviz.nev
FROM telepulesgps, helykapcs, alloviz
WHERE alloviz.id=allovizid AND telepulesgps.id=gpsid
GROUP BY allovizid, alloviz.nev
ORDER BY max(hosszusag)-min(hosszusag) DESC;

7egyegy, (nem kell)
SELECT alloviz.nev, terulet, telepulesgps.nev
FROM alloviz, helykapcs, telepulesgps
WHERE alloviz.id=allovizid AND telepulesgps.id=gpsid
AND allovizid in (
SELECT allovizid
FROM helykapcs
GROUP BY allovizid
HAVING Count(gpsid)=1)
AND gpsid in (
SELECT gpsid
FROM helykapcs
GROUP BY gpsid
