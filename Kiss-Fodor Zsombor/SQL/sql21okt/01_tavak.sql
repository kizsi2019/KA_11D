-- https://dload-oktatas.educatio.hu/erettsegi/feladatok_2022tavasz_emelt/e_inf_22maj_fl.pdf

DROP DATABASE IF EXISTS tavak;
CREATE DATABASE tavak;
use tavak;

CREATE TABLE alloviz (
	id INT,
	nev VARCHAR(30),
	tipus VARCHAR(30),
	terulet FLOAT,
	vizgyujto INT,
	PRIMARY KEY (id)
);

CREATE TABLE telepulesgps (
	id INT,
	nev VARCHAR(30),
	hosszusag FLOAT,
	szelesseg FLOAT,
	PRIMARY KEY (id)
);

CREATE TABLE helykapcs (
	allovizid INT,
	gpsid INT,
	FOREIGN KEY (allovizid) REFERENCES alloviz (id),
	FOREIGN KEY (gpsid) REFERENCES telepulesgps (id)
);