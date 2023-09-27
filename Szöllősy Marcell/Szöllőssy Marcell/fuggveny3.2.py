def harommal_oszthato(x, *args):
    darab = 0
    i = 0
    while i <len(args):
        if args[i] % 3 == 0:
            darab = darab + 1
        i = i + 1
    return darab
lista = []
szam = input("Adj meg egy számot!")
while int(szam) >= 0:
    lista.append(szam)
    szam = input("Adj meg egy számot!")
print(lista)
print(harommal_oszthato(22,12,32,33,6,9,69))