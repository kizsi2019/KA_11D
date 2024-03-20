# SQLALchemy Tutorial alapján
# https://docs.sqlalchemy.org/en/14/tutorial/index.html

from sqlalchemy import create_engine
from sqlalchemy import text

# Az engine objektum teremti meg a kapcsolatot az adatbázissal,
# illetve ha az nem létezik, létrehozza
# sqlite - milyen adatbázissal kommunikál
# pysqlite - milyen DBAPI-jal (ha nem adjuk meg, akkor az alapértelmezettet használja)
# :///test.db - az adatbázis relatív elérési útvonala
# exho: részletes tájékoztatás a műveletekről
# future: 2.0 verzió stílusát használhatjuk
engine = create_engine('sqlite+pysqlite:///test2.db', echo=True, future=True)

# text() szükséges a szöveges SQL utasítások használatához!
# az engine.connect() esetében szükség van a commit() metódus hívására
with engine.connect() as conn:
    conn.execute(text('CREATE TABLE user (name varchar(20), age int)'))
    conn.execute(text('INSERT INTO user (name, age) VALUES (:name, :age)'),
                 [{'name': 'Peti', 'age': 17}, {'name': 'Luca', 'age': 16}], )
    conn.commit()

# természetesen ez a lekérdezés lehetne az előző blokkban is
with engine.connect() as conn:
    result = conn.execute(text('SELECT name, age FROM user'))
    for row in result:
        print(f'name: {row.name}  age: {row.age}')

# engin.begin() esetén NEM kell hívni a commit() metódust, ez automatikusan megtörténik
# ennek használata gyakoribb kivéve a DDL utasításokat
with engine.begin() as conn:
    conn.execute(text('INSERT INTO user (name, age) VALUES (:name, :age)'),
                 [{'name': 'Botond', 'age': 20}, {'name': 'Léda', 'age': 6}], )

    result = conn.execute(text('SELECT name, age FROM user'))
    for row in result:
        # így is hivatkozhatunk az adatokra
        print(f'name: {row[0]}  age: {row[1]}')
