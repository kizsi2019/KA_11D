import random
from pprint import pformat, PrettyPrinter

osztály = ['A', 'B', 'C', 'D']
vezeteknevek = ["Kiss", "Horváth", "Szabó", "Pethő", "Szalai", "Nagy"]
keresztnevek = ["Petra", "Ádám", "Levente", "Zoé", "Hanna"]
telepulesek = ["Sopron", "Fertőszentmiklós", "Harka", "Kópháza", "Fertőd", "Újkér"]
utcak = ["Fő", "Kossuth", "Győri", "Petőfi", "Vadvirág", "Iskola"]


adatok = {

    'diakok': [
        {
            'vezetéknév': random.choice(vezeteknevek),
            'keresztnév': random.choice(keresztnevek),
            'évfolyam': random.randint(9, 12),

            'cím': {
                'település': random.choice(telepulesek),
                'utca': random.choice(utcak),
                'házszám': random.randint(1, 50)
            },
        }
    ],

    'diak': [
        {
            'vezetéknév': random.choice(vezeteknevek),
            'keresztnév': random.choice(keresztnevek),
            'évfolyam': random.randint(9, 12),

            'cím': {
                'település': random.choice(telepulesek),
                'utca': random.choice(utcak),
                'házszám': random.randint(1, 50)
            },
        }
    ]

}

szoveg = pformat(adatok['diakok'], sort_dicts=False)
eltavolitando_karakterek = ['[', ']', '{', '}', "'"]
for karakter in eltavolitando_karakterek:
    szoveg = szoveg.replace(karakter, "")


    print(szoveg)



