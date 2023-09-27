def szam_felismeres():
    szam = int(input("Adj meg egy számot!"))
    negatív = 'A szám negatív'
    pozitív = 'A szám pozitív'
    nulla = 'A szám nulla'
    if szam > 0:
        print(pozitív)
    elif szam < 0:
        print(negatív)
    else:
        print(nulla)

szam_felismeres()