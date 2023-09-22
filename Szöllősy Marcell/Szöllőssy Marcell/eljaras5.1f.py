oszlop2 = int(input("Add meg az oszlopot!"))
sor2 = int(input("Add meg a sort!"))


sor = 1
while sor <= 3:
    oszlop = 1
    while oszlop <= 6:
        if oszlop2 != oszlop or sor2 != sor:
            print('O ', end='')
        if oszlop2 == oszlop and sor2 == sor:
            print('+ ', end='')
        oszlop = oszlop + 1
    print('')
    sor = sor + 1
