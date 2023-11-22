-- 3.
SELECT nev, orszag FROM allomas WHERE orszag != ""
ORDER BY nev

-- 4.
SELECT nev, tipus, tav FROM allomas, hely WHERE vonalid = "80" AND mukodo AND allomas.id = allomasid
ORDER BY tav

-- 5.
SELECT vonalid, MAX(tav) FROM hely
GROUP BY vonalid

-- 6.
SELECT vonalid, nev, veg.nev FROM
	(
	SELECT nev, vonalid
	FROM allomas, hely
	WHERE allomas.id=allomasid
	AND tav=0
	) AS indulasi,
	(
	SELECT nev, vonalid, tav
	FROM allomas, hely
	WHERE allomas.id=allomasid
	) AS veg,
	(
	SELECT vonalid, Max(tav) AS maxtav
	FROM hely
	GROUP BY vonalid
	) AS tulso
WHERE indulasi.vonalid=veg.vonalid
	AND veg.vonalid=tulso.vonalid
	AND veg.tav=tulso.maxtav;
	
-- 7.
SELECT allomas.nev, hely.vonalid FROM allomas, hely WHERE allomas.id=hely.allomasid AND vonalid IN (SELECT hely.vonalid FROM allomas, hely WHERE allomas)...

-- 8.
SELECT nev, COUNT(*) FROM allomas, hely WHERE allomas.id=hely.allomasid
GROUP BY nev HAVING COUNT(*)>=5
ORDER BY COUNT(*) DESC

-- 9.
SELECT nev, tav, vonalid from allomas, hely WHERE allomas.id=hely.allomasid AND tav > 90 AND tav < 100 AND vonalid="140"