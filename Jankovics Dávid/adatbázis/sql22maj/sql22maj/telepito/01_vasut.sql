-- https://dload-oktatas.educatio.hu/erettsegi/feladatok_2022tavasz_emelt/e_inf_22maj_fl.pdf

DROP DATABASE IF EXISTS vasut;
CREATE DATABASE vasut;
use vasut;

CREATE TABLE allomas (
	id INT,
	nev VARCHAR(30),
	tipus VARCHAR(30),
	orszag VARCHAR(30),
	mukodo TINYINT,
	PRIMARY KEY (id)
);

CREATE TABLE vonal (
	id VARCHAR(30),
	kisvasut TINYINT,
	mukodo TINYINT,
	PRIMARY KEY (id)
);

CREATE TABLE hely (
	id INT,
	vonalid VARCHAR(30),
	allomasid INT,
	tav INT,
	PRIMARY KEY (id),
	FOREIGN KEY (vonalid) REFERENCES vonal (id),
	FOREIGN KEY (allomasid) REFERENCES allomas (id)
);