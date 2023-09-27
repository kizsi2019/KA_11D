darab_karakter = int(input("Adj meg egy számot!"))
sor = 1
while sor <= 8:
    oszlop = darab_karakter % 2
    while oszlop <= darab_karakter:
        print('0 ', end='')
        oszlop += 1
    print('')
    darab_karakter += 1
    sor += 1