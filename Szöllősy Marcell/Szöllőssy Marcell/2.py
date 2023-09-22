def legnagyobb_szam(szamok):
    legnagyobb = szamok[0]
    for szam in szamok:
        if szam > legnagyobb:
            legnagyobb = szam
    return legnagyobb

szamok = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(legnagyobb_szam(szamok))
