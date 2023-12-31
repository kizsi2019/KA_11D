CREATE DATABASE tavak DEFAULT CHARSET = utf8 COLLATE utf8_hungarian_ci;

SELECT nev, terulet FROM `alloviz` WHERE tipus LIKE "%morotva%" ORDER BY terulet DESC;

SELECT SUM(terulet)/93036 * 100 AS "arány" FROM alloviz;

SELECT nev, tipus, terulet FROM `alloviz` WHERE terulet BETWEEN 3 AND 10 AND vizgyujto / 10 >= terulet;

SELECT alloviz.nev, COUNT(telepulesgps.id) FROM telepulesgps, alloviz, helykapcs WHERE alloviz.id = helykapcs.allovizid AND telepulesgps.id = helykapcs.gpsid GROUP BY alloviz.id HAVING COUNT(telepulesgps.id) >= 3;

SELECT alloviz.nev FROM telepulesgps, helykapcs, alloviz WHERE alloviz.id = allovizid AND telepulesgps.id = gpsid GROUP BY allovizid, alloviz.nev ORDER BY MAX(hosszusag)-MIN(hosszusag) DESC LIMIT 1;

SELECT alloviz.nev, terulet, telepulesgps.nev FROM alloviz, helykapcs, telepulesgps WHERE alloviz.id=allovizid And telepulesgps.id=gpsid And allovizid = helykapcs.allovizid And gpsid = helykapcs.gpsid;

SELECT alloviz.nev AS "tó név", alloviz.terulet AS "tó terület" FROM alloviz WHERE alloviz.tipus IS NOT NULL ORDER BY alloviz.tipus;