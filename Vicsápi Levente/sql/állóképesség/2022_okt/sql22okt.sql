-- 2. feladat
SELECT megye.letszam
FROM megye
WHERE megye.nev='Vas';

-- 3. feladat
SELECT sum(aerob.letszam)
FROM aerob, megye
WHERE aerob.mkod=megye.kod AND megye.nev='Somogy';

-- 4. feladat
SELECT aerob.letszam
FROM aerob, megye, allapot
WHERE aerob.mkod=megye.kod AND aerob.allkod=allapot.kod 
  AND megye.nev='Zala' AND aerob.nem=1 
  AND allapot.nev='egészséges';

-- 5. feladat  
SELECT count(megye.nev) 
FROM megye
WHERE megye.letszam<(
	SELECT megye.letszam 
	FROM megye 
	WHERE megye.nev="Heves");

-- 6. feladat
SELECT sum(aerob.letszam)/megye.letszam
FROM aerob, megye
WHERE aerob.mkod=megye.kod AND megye.nev='Pest';

-- 7. feladat
SELECT megye.nev, aerob.letszam
FROM aerob, megye, allapot
WHERE aerob.mkod=megye.kod 
	AND nem=0 AND allkod=allapot.kod AND allapot.nev='egészséges'
ORDER BY aerob.letszam DESC;

-- 8. feladat
SELECT megye.nev, SUM(aerob.letszam)/megye.letszam
FROM megye, aerob
WHERE aerob.mkod=megye.kod
GROUP BY megye.nev
ORDER BY 2 DESC
LIMIT 1;

-- 9. feladat
SELECT megye.nev AS Megyenév, sum(aerob.letszam)/megye.letszam AS Arány
FROM megye, aerob, allapot  
WHERE aerob.mkod=megye.kod AND aerob.allkod=allapot.kod
AND allapot.nev LIKE '%fejlesztés%'
GROUP BY aerob.mkod
HAVING Arány>0.25;
