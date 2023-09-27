szo = 'kalashnikov'
szo2 = input("Adj meg egy betűt")

index = 0
talalat = False
while index < len(szo) and not talalat:
    if szo2 == szo[index]:
        talalat = True
    index += 1



if talalat:
    print("Ilyen betű szerepel ebben a szóban:")
else:
    print("Ilyen betű nincs ebben a szóban:")

print(szo)