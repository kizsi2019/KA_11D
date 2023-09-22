import random

yes = 0

while yes <= 20:
    szam = random.randint(1, 12)
    if szam % 2 == 1:
        print(szam)
    yes += 1