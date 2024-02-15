// 1. feladat //

SELECT versenyzok.nev, versenyzok.szul_dat 
FROM versenyzok 
WHERE versenyzok.szul_hely = 'Szeged' AND versenyzok.szul_dat >= '1981-01-01' 
ORDER BY nev;
    
// 2. feladat //

SELECT versenyszamok.versenyszam, eredmenyek.helyezes, eredmenyek.megjegyzes 
FROM versenyzok, eredmenyek, versenyszamok 
WHERE versenyzok.azon = eredmenyek.versenyzo_azon 
AND eredmenyek.versenyszam_azon = versenyszamok.azon 
AND versenyzok.nev = 'Vajda Attila';
    
// 3. feladat //

SELECT DISTINCT orszagok.orszag 
FROM eredmenyek, versenyzok, orszagok 
WHERE eredmenyek.helyezes = 1 AND eredmenyek.versenyzo_azon = versenyzok.azon 
AND versenyzok.orszag_azon = orszagok.azon;

// 4. feladat //

SELECT versenyzok.nev, versenyzok.szul_hely, versenyzok.szul_dat 
FROM versenyzok 
WHERE versenyzok.szul_dat > 
(
SELECT versenyzok.szul_dat
FROM versenyzok
WHERE versenyzok.nev = 'Cseh László'
)

// 5. feladat //

SELECT * FROM orszagok 
WHERE orszagok.foldresz = 'Európa' 
AND orszagok.azon NOT IN
(
SELECT versenyzok.orszag_azon 
FROM versenyzok
)

// 6. feladat //

SELECT orszagok.foldresz, COUNT(*), SUM(orszagok.lakossag), AVG(orszagok.terulet)
FROM orszagok
WHERE orszagok.foldresz IS NOT NULL
GROUP BY orszagok.foldresz
