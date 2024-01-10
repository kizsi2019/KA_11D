SELECT nev, tomeg, ar FROM `keverek` WHERE tomeg != 20 ORDER BY tomeg DESC;

SELECT nev, ar * 1000 / tomeg AS "ft/kg" FROM `keverek`ORDER BY ar / tomeg DESC LIMIT 1;

SELECT COUNT(DISTINCT keverekid) FROM kapcsolat, osszetevo WHERE osszetevoid = osszetevo.id AND nev = 'bazsalikom';

SELECT keverek.nev, COUNT(kapcsolat.osszetevoid) AS osszetevoszam FROM kapcsolat, osszetevo, keverek WHERE osszetevoid = osszetevo.id AND keverekid = keverek.id GROUP BY keverek.nev ORDER BY osszetevoszam DESC;

SELECT keverek.nev FROM keverek, kapcsolat, osszetevo WHERE keverek.id = kapcsolat.keverekid AND keverek.id = kapcsolat.keverekid NOT LIKE osszetevo.nev = "%bors" GROUP BY keverek.id;

SELECT keverek.nev FROM keverek INNER JOIN kapcsolat AS kapcsolat ON keverek.id = kapcsolat.keverekid INNER JOIN osszetevo AS osszetevo ON kapcsolat.osszetevoid = osszetevo.id WHERE osszetevo.nev = 'paradicsom' AND keverek.nev IN (SELECT keverek.nev FROM keverek INNER JOIN kapcsolat AS kapcsolat ON keverek.id = kapcsolat.keverekid INNER JOIN osszetevo AS osszetevo ON kapcsolat.osszetevoid = osszetevo.id WHERE osszetevo.nev = 'chili');