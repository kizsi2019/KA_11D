1.

SELECT nev, szul_dat, egyen_csapat, szul_hely FROM `versenyzok` 
WHERE egyen_csapat LIKE '%%e%%' AND YEAR(szul_dat) LIKE "198%%" AND szul_hely LIKE "%%Szeged%%";
order by nev

2.
SELECT versenyszamok.versenyszam, eredmenyek.helyezes, eredmenyek.megjegyzes 
    FROM versenyzok, eredmenyek, versenyszamok 
    WHERE versenyzok.azon = eredmenyek.versenyzo_azon 
        AND eredmenyek.versenyszam_azon = versenyszamok.azon 
        AND versenyzok.nev = 'Vajda Attila';

3.

SELECT DISTINCT orszagok.orszag 
    FROM eredmenyek, versenyzok, orszagok 
    WHERE eredmenyek.helyezes = 1 AND eredmenyek.versenyzo_azon = versenyzok.azon 
      AND versenyzok.orszag_azon = orszagok.azon;

4.

SELECT nev, szul_dat, szul_hely FROM `versenyzok` where Year(szul_dat) > "1985-12-03";

5.

 SELECT * FROM orszagok 
    WHERE orszagok.foldresz = 'Európa' 
      AND orszagok.azon NOT IN (SELECT versenyzok.orszag_azon FROM versenyzok);S

6.
    SELECT orszagok.foldresz, COUNT(*), SUM(orszagok.lakossag), AVG(orszagok.terulet) 
    FROM orszagok 
    WHERE orszagok.foldresz IS NOT NULL 
    GROUP BY orszagok.foldresz;


7.
SELECT orszagok.orszag 
    FROM orszagok, versenyzok  
    WHERE orszagok.azon = versenyzok.orszag_azon 
      AND versenyzok.szul_dat = (SELECT MAX(versenyzok.szul_dat) FROM versenyzok);
    


8.
CREATE TABLE pont_tabla 
    SELECT orszagok.orszag, erem_tabla.arany*3+erem_tabla.ezust*2+erem_tabla.bronz AS pont 
    FROM orszagok, erem_tabla 
    WHERE orszagok.azon = erem_tabla.orszag_azon 
    HAVING pont >= 20;
    


9.
 SELECT versenyzok.nev FROM versenyzok WHERE versenyzok.azon IN (
	    SELECT csapattagok.versenyzo_azon FROM csapattagok
        WHERE csapattagok.csapat_azon = (
            SELECT versenyzok.azon FROM versenyzok, orszagok
            WHERE versenyzok.orszag_azon = orszagok.azon 
                AND versenyzok.nev = 'Kézilabda női' AND orszagok.orszag = 'Magyarország'
        )
    ) ORDER BY versenyzok.szul_dat DESC;
    
10.

 UPDATE versenyzok 
    SET szul_hely = (
        SELECT orszagok.fovaros FROM orszagok 
        WHERE orszagok.azon = versenyzok.orszag_azon) 
    WHERE versenyzok.egyen_csapat = 'c';    
  