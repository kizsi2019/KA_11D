szo = 'kalashnikov'

index = 0
talalat = False
szo2 = input("Adj meg egy betűt")

while szo2 != "":
    szo2 =input("adj meg egy betűt")
    while index < len(szo) and not talalat:
        if szo2 == szo[index]:
            talalat = True
    index += 1
    szo2 = input("Adj meg egy betűt")



if talalat:
    print("Ilyen betű szerepel ebben a szóban:")
else:
    print("Ilyen betű nincs ebben a szóban:")

print(szo)