USE olimpia;
-- Módosítások:
-- DROP TABLE +"IF EXISTS" ... -"purge"
-- NUMBER() <--> INTEGER() --> INT
-- VARCHAR2 <--> VARCHAR 
-- O_NAGYBETUS --> kisbetus
-- mezőnevek kisbetűsek

DROP TABLE IF EXISTS eredmenyek;
DROP TABLE IF EXISTS versenyszamok;
DROP TABLE IF EXISTS sportagak;
DROP TABLE IF EXISTS csapattagok;
DROP TABLE IF EXISTS versenyzok;
DROP TABLE IF EXISTS erem_tabla;
DROP TABLE IF EXISTS orszagok;

CREATE TABLE orszagok(
    azon INT, 
    orszag VARCHAR(50), 
    terulet INT, 
    lakossag INT, 
    fovaros VARCHAR(40),
    foldresz VARCHAR(50), 
      CONSTRAINT O_ORSZ_PK PRIMARY KEY (azon),
      CONSTRAINT O_ORSZ_UK_ORSZ UNIQUE (orszag)
);
  
CREATE TABLE erem_tabla(
    orszag_azon INT, 
    arany INT, 
    ezust INT, 
    bronz INT, 
      CONSTRAINT O_ET_PK PRIMARY KEY (orszag_azon),
      CONSTRAINT O_ET_FK FOREIGN KEY (orszag_azon) REFERENCES orszagok (azon)
);
 
CREATE TABLE versenyzok(
    azon INT,
    nev VARCHAR(50),
    szul_dat DATE,
    orszag_azon INT,
    egyen_csapat VARCHAR(1),
    szul_hely VARCHAR(50),
      CONSTRAINT O_VERS_PK PRIMARY KEY(azon),
      CONSTRAINT O_VNY_UK UNIQUE (nev,orszag_azon,szul_dat),
      CONSTRAINT O_VERS_FK_ORSZ FOREIGN KEY (orszag_azon) REFERENCES orszagok (azon)
);
          
CREATE TABLE csapattagok (
    versenyzo_azon INT, 
    csapat_azon INT, 
      CONSTRAINT O_CST_PK PRIMARY KEY (versenyzo_azon, csapat_azon), 
      CONSTRAINT O_CST_FK_CS FOREIGN KEY (csapat_azon) REFERENCES versenyzok (azon), 
      CONSTRAINT O_CST_FK_T FOREIGN KEY (versenyzo_azon) REFERENCES versenyzok (azon)
);
          
CREATE TABLE sportagak (
    azon INT, 
    nev VARCHAR(50), 
      CONSTRAINT O_SPAG_PK PRIMARY KEY (azon),
      CONSTRAINT O_SPAG_UK UNIQUE (nev)
);    

CREATE TABLE versenyszamok (
    azon INT, 
    sportag_azon INT, 
    versenyszam VARCHAR(50), 
    ferfi_noi VARCHAR(5), 
      CONSTRAINT O_VSZAM_PK PRIMARY KEY (azon),
      CONSTRAINT O_VSZAM_UK UNIQUE (sportag_azon, versenyszam, ferfi_noi),
      CONSTRAINT O_VSZAM_FK_SP FOREIGN KEY (sportag_azon) REFERENCES sportagak (azon)
);

CREATE TABLE eredmenyek (
    versenyzo_azon INT,
    versenyszam_azon INT,
    helyezes INT,
    megjegyzes VARCHAR(150),
      CONSTRAINT O_E_PK PRIMARY KEY  (versenyzo_azon, versenyszam_azon),
      CONSTRAINT O_E_FK_VSZ FOREIGN KEY (versenyszam_azon) REFERENCES versenyszamok (azon),
      CONSTRAINT O_E_FK_VNY FOREIGN KEY (versenyzo_azon) REFERENCES versenyzok (azon)
);

