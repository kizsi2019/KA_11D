import sqlite3

con = sqlite3.connect('proba.db')

cur = con.cursor()

cur.execute('DROP TABLE IF EXISTS gyakorlas')
cur.execute('CREATE TABLE gyakorlas(Nev, Varos, Szuletesi_ev)')

adatok = [
    ('Levi', 'Ócsa', 2004),
    ('Gazsi', 'Budapest', 1980),
    ('Rita', 'Nagykanizsa', 2002)
]

cur.executemany('INSERT INTO gyakorlas VALUES(?,?,?)', adatok)

con.commit()
