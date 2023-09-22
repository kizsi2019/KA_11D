def paros_e(x,y, szam = None):
    if x % 2 == 0 or y % 2 == 0:
        szam = True
    else:
        szam = False

    return szam

x = int(input('x'))
y = int(input('y'))

print(paros_e(y,x))