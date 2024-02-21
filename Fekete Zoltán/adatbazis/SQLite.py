# forrás: https://docs.python.org/3/library/sqlite3.html
import sqlite3

# A Connection típusú objektum létrehozza a kapcsolatot az adatbázissal,
# ha nem létezik az adatbázis, létrehozza azt
con = sqlite3.connect("tutorial.db")

# A cursor objektum metódusaival valóstíhatjuk meg az SQL utasításokat
cur = con.cursor()

# Nem feltétlenül szükséges megadni az oszlop típusát!
cur.execute("CREATE TABLE movie(title, year, score)")
# cur.execute('DROP TABLE movie')


cur.execute("""
    INSERT INTO movie VALUES
        ('Monty Python and the Holy Grail', 1975, 8.2),
        ('And Now for Something Completely Different', 1971, 7.5)
""")

# A változások mentéséhez szükséges a commit() metódus hívása!
con.commit()

res = cur.execute("SELECT title FROM movie")
print(res.fetchall())

# Paraméterezett SQL utasítások végrehajtása
# Placeholderek alkalamazásával elkerülhetőek az SQL injection támadások
data = [
    ("Monty Python Live at the Hollywood Bowl", 1982, 7.9),
    ("Monty Python's The Meaning of Life", 1983, 7.5),
    ("Monty Python's Life of Brian", 1979, 8.0),
]
cur.executemany("INSERT INTO movie VALUES(?, ?, ?)", data)
con.commit()

for row in cur.execute("SELECT year, title FROM movie ORDER BY year"):
    print(row)

# Zárja a kapcsolatot
con.close()

