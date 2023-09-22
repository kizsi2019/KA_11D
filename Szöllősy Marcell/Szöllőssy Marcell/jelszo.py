felhasznalo = "bori99"
jelszo = "Szivecske<3"

falhasz = input("Kérem adja meg a felhasználónevet")
jelsz = input("Kérem adja meg a jelszót")

while felhasznalo != falhasz or jelszo != jelsz:
    if felhasznalo != falhasz or jelszo != jelsz:
        print("Belépés megtagadtava")
        falhasz = input("Kérem adja meg a felhasználónevet")
        jelsz = input("Kérem adja meg a jelszót")

print("Belépés engedélyezve")