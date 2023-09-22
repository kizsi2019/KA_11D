név = input("Vizsgázó neve: ")
pontszám = int(input("Vizsgázó pontszáma: "))

if pontszám >= 48:
    print(név + " Vizsgája sikeres!")
else:
    print(név + " Vizsgája sikertelen.")
