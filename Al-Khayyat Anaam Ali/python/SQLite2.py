
# forrás: https://docs.python.org/3/library/sqlite3.html
import sqlite3

# Ha az adatbázis elérési útvonala helyett :memory: értéket adunk meg,
# az adatbázis a RAM-ban (memóriában) jön létre a merevlemez helyett.
con = sqlite3.connect(":memory:")

# A Connection osztály is tartalmaz execute(), executemany(), executescript() metódusokat,
# ebben az esetben a háttérben létrejön a curosr objektum, 
# ennek létrehozásáról nem kell külön gondoskodnunk
con.execute("CREATE TABLE lang(id INTEGER PRIMARY KEY, name VARCHAR UNIQUE)")

# Amennyiben a sikeres volt a művelet, a context manager automatikusan
# hívja a commit() metódust
with con:
    con.execute("INSERT INTO lang(name) VALUES(?)", ("Python",))

# A context manager csupán a commit metódus hívását automatizálja
# a bezárásról külön kell gondoskodnunk!
con.close()
        
  