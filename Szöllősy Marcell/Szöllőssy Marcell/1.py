import random


def paros_szamok(szamlista):
    parosok = []
    for szam in szamlista:
        if szam % 2 == 0:
            parosok.append(szam)
    return parosok

szamok = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(paros_szamok(szamok))

# számok = [1,2,3,4,5,7,8,9,10]
# szamok = []
# for i in range(10):
# szam = random.randint(1,10)
# szamok.append(szam)

szam = input("Adja meg az első számot: ")
while szam != "":
    szamok.append(int(szam))
    szam = input("Adja me a következő számot (Enterrel kilép): ")
parosok