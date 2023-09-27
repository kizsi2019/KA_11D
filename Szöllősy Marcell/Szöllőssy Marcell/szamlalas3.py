szavak = ['Elemér', 'Emma', 'ajtó', 'róka', 'egér']

találat = False
darab = 0
for szo in szavak:
    if szo[0] == 'e' or szo[0] == 'E':
        találat = True
        darab += 1
    else:
        találat = False

    if találat:
        print(szo)







print('Ennyi e/E betűs szó van a listában' ,darab)