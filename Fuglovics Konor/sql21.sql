-- 2.
SELECT nev, tomeg, ar FROM keverek WHERE tomeg != 20;

-- 3.
/*???*/

-- 4.
SELECT keverek.nev, osszetevo.nev
FROM keverek, kapcsolat, osszetevo
WHERE osszetevo.id = 7;
-- 5.
/*???*/

-- 6.
SELECT DISTINCT(keverek.nev)
FROM keverek, osszetevo
WHERE osszetevo.nev NOT LIKE "%bors"

-- 7.
/*???*/