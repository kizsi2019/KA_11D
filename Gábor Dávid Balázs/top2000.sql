1.feladat

SELECT lista.ev, dalok.cim, eloadok.nev
FROM lista, dalok, eloadok
WHERE lista.ev = '2001' AND lista.helyezes = 1
AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;  

2. feladat

SELECT lista.ev, dalok.cim, eloadok.nev
FROM lista, dalok, eloadok
WHERE lista.ev = '2001' AND lista.helyezes = 1 or 2 or 3
AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;

3. feladat

SELECT lista.ev, dalok.cim, eloadok.nev WHERE eloadok.nev, dalok.cim LIKE 's%';
FROM lista, dalok, eloadok
WHERE lista.ev = '2001' AND lista.helyezes = 1 or 2 or 3
AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;