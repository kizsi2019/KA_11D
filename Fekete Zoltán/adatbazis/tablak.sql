DROP DATABASE IF EXISTS muhely;
  CREATE DATABASE muhely;
  USE muhely;
  
  
DROP TABLE IF EXISTS tulajdonosok;
  DROP TABLE IF EXISTS szgk;
  
  CREATE TABLE szgk(
      id INT, 
      tipus VARCHAR(20), 
      modell VARCHAR(20), 
      rendszam VARCHAR(15), 
      ajtok_szama INT,
      gyartas_eve DATE
  );
  
  INSERT INTO szgk (id, tipus, modell, rendszam, ajtok_szama, gyartas_eve)
  VALUES(10, 'Opel', 'Corsa C', 'AAA123', 4, '2002-10-03'); 

  CREATE TABLE tulajdonosok(
      tul_id INT, 
      nev VARCHAR(60),
      lakhely VARCHAR(60),
      szgk_id INT,
      PRIMARY KEY (tul_id),
      FOREIGN KEY (szgk_id) REFERENCES szgk (id)
  );
  
  INSERT INTO tulajdonosok (id, nev, lakhely)
  VALUES(1, 'Kovács István', 'Budapest'); 