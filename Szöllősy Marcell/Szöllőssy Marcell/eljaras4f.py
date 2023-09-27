def szo_hasonlitas():
    szavak = []
    chance = 0
    while chance != 3:
        szo = input('Adj meg egy szót!')
        chance += 1
        if chance != 3:
            szavak.append(szo)
        max = szavak[0]
        for szo in szavak:
            if szo > max:
                max = szo
    print('Ez a leghosszabb szó:', max)
szo_hasonlitas()