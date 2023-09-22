import random

szamok = []
darab = 0

for i in range(5):
    szam = random.randint(1, 10)
    szamok.append(szam)
    if szam % 2 == 0:
        darab += 1

print(szamok)
print('Ennyi páros szám van a listában', darab)






