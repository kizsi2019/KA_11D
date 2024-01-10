DROP DATABASE IF EXISTS fuszerkeverek;
CREATE DATABASE fuszerkeverek;
use fuszerkeverek;

CREATE TABLE keverek (
	id INT,
	nev VARCHAR(30),
	ar INT,
	tomeg INT,
	szarmazas VARCHAR(30),
	ajanlat VARCHAR(60),
	PRIMARY KEY (id)
);


CREATE TABLE osszetevo (
	id INT,
	nev VARCHAR(30),
	PRIMARY KEY (id)
);


CREATE TABLE kapcsolat (
	keverekid INT,
	osszetevoid INT,
	FOREIGN KEY (keverekid) REFERENCES keverek (id),
	FOREIGN KEY (osszetevoid) REFERENCES osszetevo (id)
);