def szam_hasonlitas():
    szam = input("Adj meg egy számot!")
    szam2 = input("Adj meg egy másik számot!")
    if szam2 > szam:
        print('' + szam2+',nagyobb mint ', szam)
    elif szam > szam2:
        print('' + szam + ',nagyobb mint', szam2)
    else:
        print('A két szám egyenlő')
szam_hasonlitas()