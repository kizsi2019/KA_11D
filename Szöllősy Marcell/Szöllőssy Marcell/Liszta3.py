import random

def main():
  lista = [[random.randint(-5, 5) for i in range(3)] for j in range(5)]
  print("Kétdimenziós lista elemei:")
  for i in lista:
    print(i)

  for i in lista:
    i[:] = [x for x in i if x >= 0]
  print("Negatív számok törölve:")
  for i in lista:
    print(i)

if __name__ == '__main__':
  main()


'''A fenti python program létrehozza a kért kétdimenziós listát, amely ötször három darab véletlenszámot tartalmaz a [-5;5] intervallumból. A random.randint() függvény segítségével generálunk véletlenszámokat a megadott intervallumban.

A main() függvényben létrejön a lista, és először kiírjuk a képernyőre. A kétdimenziós listát egy for ciklussal járjuk végig, és a belső for ciklussal hozzáférünk a lista egyes elemeihez.

A negatív számok törlésére egy második for ciklust használunk, amely ugyanúgy végigmegy a kétdimenziós listán. Az elemeken belül egy lista értékadás történik, amely egy új listát ad vissza, amely csak a pozitív számokat tartalmazza az eredeti lista elemeiből.

Végül ismét kiírjuk a képernyőre a listát a negatív számok törlését követően.

A program végén van egy if __name__ == '__main__': blokk, amely biztosítja, hogy a program csak akkor fusson le, ha közvetlenül futtatják, és nem más fájl importálja.'''