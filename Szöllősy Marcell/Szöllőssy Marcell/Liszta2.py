tarolo = [["O", "O", "O"],
          ["O", "O", "O"],
          ["O", "O", "O"]]

def rajzol(tarolo):
    for i in range(len(tarolo)):
        for j in range(len(tarolo[i])):
            print(tarolo[i][j], end=" ")
        print("")

while True:
    x = int(input("Adja meg az x koordinátát (0-2): "))
    y = int(input("Adja meg a y koordinátát (0-2): "))
    if x < 0 or x > 2 or y < 0 or y > 2:
        break
    tarolo[y][x] = "+"
    rajzol(tarolo)

'''A program létrehozza egy 3x3-as tarolo nevű listát, amelynek minden eleme "O". Az rajzol függvény megjeleníti a tarolo lista tartalmát 3x3-as rács formájában.

A program a while ciklust használja a koordináták bekérése céljából, amely addig folytatódik, amíg a felhasználó nem ad meg intervallumon kívüli értéket (0-2). Ha a bekért érték intervallumon belüli, akkor a tarolo lista megfelelő elemét (megadott x és y koordináták alapján) átírjuk '+' -ra. Minden bekérés után a rajzol függvénnyel megjelenítjük a rácsot. Ha a bekért érték intervallumon kívüli, a ciklus kilép, és a program véget ér.'''