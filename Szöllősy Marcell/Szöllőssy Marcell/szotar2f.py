macska = {
    'neve': 'Cirmi',
    'életkor': 2,
}


adat = input("melyik adatot nyomtassam ki (neve/életkor)?")
if adat == 'neve':
    print(macska['neve'])
    kerdes = input("mire modósítsam?")
    macska['neve'] = kerdes
    print(macska)


if adat == 'életkor':
    print(macska['életkor'])
    kerdes2 = input("mire modósítsam?")
    macska['életkor'] = kerdes2
    print(macska)

input()



