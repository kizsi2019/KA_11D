DROP DATABASE IF EXISTS muhely;
DROP DATABASE IF EXISTS szgk;
CREATE TABLE muhely;
CREATE TABLE szgk(
	id INT PRIMARY KEY AUTO_INCREMENT,
	tipus VARCHAR(20) DEFAULT 'Toyota',
	modell VARCHAR(20) NOT NULL, 
	rendszam VARCHAR(15), ,
	gyartas_eve DATE
);
  
INSERT INTO szgk (tipus, modell, rendszam, gyartas_eve)
VALUES('Opel', 'Corsa C', 'AAA123', '2002-10-03'); 

DROP TABLE IF EXISTS tulajdonosok;
CREATE TABLE tulajdonosok(
	tul_id INT, 
	nev VARCHAR(60),
	lakhely VARCHAR(60),
	id INT,
	FOREIGN KEY (id) REFERENCES szgk (id)
);

INSERT INTO tulajdonosok (tul_id, nev, lakhely)
VALUES(1, 'Kovács István', 'Budapest'); 