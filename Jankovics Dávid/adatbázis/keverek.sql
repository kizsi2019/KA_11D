2

SELECT nev, tomeg, ar FROM `keverek` WHERE tomeg NOT LIKE 20 ORDER BY tomeg DESC ;

3

SELECT nev, ar / tomeg*1000 as kilokenti_ar FROM keverek ORDER BY ar / tomeg*1000 DESC LIMIT 1 ;

4

SELECT COUNT('bazsalikom') as baszalikom FROM osszetevo;

5

SELECT keverek.id, keverek.nev, 
COUNT(kapcsolat.keverekid) as 'Ősszetevok_száma' FROM keverek  
JOIN kapcsolat
ON keverek.id = kapcsolat.keverekid
JOIN osszetevo
ON osszetevo.id = kapcsolat.osszetevoid
GROUP BY keverek.id
ORDER BY COUNT(kapcsolat.keverekid) DESC limit 1;
6

SELECT distinct keverek.nev FROM `keverek` 
JOIN kapcsolat
ON keverek.id = kapcsolat.keverekid
JOIN osszetevo
ON osszetevo.id = kapcsolat.osszetevoid
WHERE osszetevo.nev not like '%bors' and keverek.nev not like '%bors';

7




