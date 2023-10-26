1. INSERT INTO `vetites`(`azon`, `mozinev`, `fkod`) VALUES ('356','Művész','2')
2. UPDATE `filmek` SET `hossz`='110' WHERE filmcim = "Álmodozók"
3. DELETE FROM `filmek` WHERE filmcim = "Film"
4. SELECT filmcim, mufaj, hossz FROM `filmek` 
5. SELECT filmcim, szarmazas FROM `filmek` ORDER BY filmcim ASC
6. SELECT filmcim, hossz FROM `filmek` WHERE mufaj = "dokumentum" ORDER BY hossz DESC
7. SELECT filmcim, hossz FROM `filmek` WHERE szarmazas = "amerikai"
8. SELECT filmcim, mufaj FROM `filmek` WHERE szinkron = "mb"
9. SELECT DISTINCT mozinev FROM `vetites` ORDER BY mozinev ASC
10. SELECT filmcim, szarmazas FROM `filmek` WHERE szarmazas = "angol"
11. SELECT filmcim, hossz FROM `filmek` WHERE filmcim LIKE 'B%'
12. SELECT filmcim, mufaj FROM `filmek` WHERE hossz > 90 && hossz < 120
13. SELECT filmcim, mufaj FROM `filmek` ORDER BY hossz DESC LIMIT 5
14. SELECT filmcim, mufaj FROM `filmek` ORDER BY hossz ASC LIMIT 10