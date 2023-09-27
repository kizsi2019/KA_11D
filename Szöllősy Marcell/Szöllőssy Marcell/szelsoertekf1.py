szamok = []




szam = None
while szam != 'X' and szam != 'x':
    szam = input('Adj meg egy számot!')
    if szam != 'X' and szam != 'x':
        szamok.append(szam)


min = szamok[0]
max = szamok[0]
for szam in szamok:
    if szam < min:
        min = szam
    if szam > max:
        max = szam


print('A legkisebb szám a listában: ', min)
print('A legnagyobb szám a listában: ', max)