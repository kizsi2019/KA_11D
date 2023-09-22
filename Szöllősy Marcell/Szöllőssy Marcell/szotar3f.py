diak = {
    'neve': 'Zoli',
    'életkor': '17',
    'kedvenc szín': 'piros'
}

print('ha nem szeretnél több adatot megadni, nyomj kétszer entert')
kerdes = None
kerdes2 = None
while kerdes != '' and kerdes != '':
    kerdes = input("mi legyen a kulcs?")
    kerdes2 = input("mi legyen az érték?")
    diak[kerdes] = kerdes2


for kulcs, ertek in diak.items():
    print(kulcs, ertek)