óra = input("Hány óra van most?")
óra = int(óra)
if óra >= 8 and óra < 16:
    print('A bolt nyitva van')
    még_ennyit_van_nyitva = 16-óra
    print('Ennyo órád van még odaérni:', 16-óra)
else:
    print('A bolt zárva van.')

