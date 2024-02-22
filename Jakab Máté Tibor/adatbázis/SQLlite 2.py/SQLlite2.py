
# forrás: https://docs.python.org/3/library/sqlite3.html
import sqlite3

con = sqlite3.connect("tutorial.db")
cur = con.cursor()

# Megadhatók pl. MySQL/MariaDB típusok is a tábla létrehozásánál
# lásd 3.1.1: https://www.sqlite.org/datatype3.html#type_affinity
cur.execute('''
    CREATE TABLE szgk(
            id INT, 
            tipus VARCHAR(20), 
            modell VARCHAR(20), 
            rendszam VARCHAR(15), 
            ajtok_szama INT,
            gyartas_eve DATE
        );
''')
cur.execute('''
    INSERT INTO szgk (id, tipus, modell, rendszam, ajtok_szama, gyartas_eve)
    VALUES(10, 'Opel', 'Corsa C', 'AAA123', 4, '2002-10-03'); 
''')
con.commit()

for row in cur.execute("SELECT * FROM szgk"):
    print(row)

con.close()    
  