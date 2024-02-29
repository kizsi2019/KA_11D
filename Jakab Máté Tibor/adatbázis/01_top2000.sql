-- forrás: https://dload-oktatas.educatio.hu/erettsegi/feladatok_2021tavasz_emelt/e_inf_21maj_fl.pdf

DROP DATABASE IF EXISTS top2000;
CREATE DATABASE top2000;
use top2000;

CREATE TABLE eloadok (
	eloadoid INT,
	nev VARCHAR(30),
	zenekar INT,
	PRIMARY KEY (eloadoid)
);


CREATE TABLE dalok (
	dalid INT,
	eloadoid INT,
	cim VARCHAR(30),
	megjelenes VARCHAR(4),
	PRIMARY KEY (dalid),
	FOREIGN KEY (eloadoid) REFERENCES eloadok (eloadoid)
);


CREATE TABLE lista (
	ev VARCHAR(4),
	helyezes INT,
	dalid INT,
	FOREIGN KEY (dalid) REFERENCES dalok (dalid)
);