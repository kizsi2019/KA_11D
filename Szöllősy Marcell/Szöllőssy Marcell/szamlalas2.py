szavak = ['alma', 'barack', 'Attila', 'kávé', 'szekrény', 'asztal']

darab = 0

for szo in szavak:
    if szo[0] == 'a' or szo[0] == 'A':
        darab += 1

print(darab)