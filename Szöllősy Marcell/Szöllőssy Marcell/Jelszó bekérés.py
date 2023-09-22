valasz = input("Adja meg a jelszót!")
jelszó = "kutyahát"
folytatja = True
while folytatja:
    if not valasz == jelszó:
        valasz = input("Add meg a jelszót)")
    else:
        folytatja = False
print("Eltaláltad a jelszót!")
