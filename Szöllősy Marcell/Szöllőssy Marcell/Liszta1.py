import random

tarolo = []

for i in range(4):
    lista = []
    for j in range(3):
        lista.append(random.randint(0, 25))
    tarolo.append(lista)

print(tarolo)

'''A program generál 4 darab három elemű véletlen egész számokat tartalmazó listát, és ezeket a tarolo nevű listába helyezi. Végül a program kiírja a képernyőre a tarolo nevű lista tartalmát.'''