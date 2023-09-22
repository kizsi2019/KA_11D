def szavak_szama(szoveg):
    szavak = szoveg.split()
    return len(szavak)

szoveg = "A nucleus egy eleme az atomnak!"
print(szavak_szama(szoveg))