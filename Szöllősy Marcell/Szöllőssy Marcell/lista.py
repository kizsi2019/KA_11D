enter = False
nameask = None
namelist = []

while nameask != '':
    nameask = input('gib word starting with a')
    if nameask == '':
        enter = True
    else:
        if nameask[0] == 'a' or nameask[0] == 'A':
            namelist.append(nameask)

print(namelist)