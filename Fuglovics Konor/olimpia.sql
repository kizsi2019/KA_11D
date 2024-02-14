-- 1.
SELECT nev, szul_dat, szul_hely FROM versenyzok WHERE szul_dat >= "1980-01-01" AND szul_hely = "Szeged"

-- 2.
SELECT eredmenyek.megjegyzes, versenyszamok.versenyszam, versenyzok.nev FROM eredmenyek, versenyszamok, versenyzok
WHERE eredmenyek.versenyzo_azon = versenyzok.azon
AND eredmenyek.versenyszam_azon = versenyszamok.azon
AND versenyzok.nev = "Vajda Attila"

-- 3.
SELECT DISTINCT(orszagok.orszag), eredmenyek.helyezes, versenyzok.nev FROM eredmenyek, versenyzok, orszagok
WHERE versenyzok.orszag_azon = orszagok.azon AND eredmenyek.versenyzo_azon = versenyzok.azon
AND eredmenyek.helyezes = "1" --?

-- 4.
SELECT nev, szul_dat, szul_hely FROM versenyzok
WHERE szul_dat > "1985-12-03"

-- 5.
	--?

-- 6.
SELECT COUNT(*), AVG(terulet), SUM(lakossag, foldresz) FROM orszagok
WHERE foldresz IS NOT NULL
GROUP BY foldresz ASC

-- 7.
SELECT MAX(versenyzok.szul_dat), orszagok.orszag, versenyzok.nev
FROM orszagok, versenyzok
WHERE versenyzok.orszag_azon = orszagok.azon

-- 8.
	--?

-- 9.
SELECT nev, szul_dat FROM versenyzok WHERE azon IN (
	SELECT versenyzo_azon FROM csapattagok
	WHERE csapat_azon=(
		SELECT v.azon FROM versenyzok AS v, orszagok AS o
		WHERE orszag_azon = o.azon
		AND nev = 'Kézilabda női' AND orszag = 'Magyarország'
	)
) ORDER BY szul_dat DESC

-- 10.
	--?
