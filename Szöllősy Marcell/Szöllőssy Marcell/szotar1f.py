kutya = {}

nev = input("add meg a kutya nevét")
kutya['név:'] = nev
eletkor = int(input("add meg a kutya életkorát"))
kutya['életkor:'] = eletkor
fajta = input("add meg a fajtáját")
kutya['fajta:'] = fajta
ervenyes_oltas = input("rendelkezik e érvényes oltással")
kutya['rendelkezik e érvényes otltással:'] = ervenyes_oltas

for kulcs, ertek in kutya.items():
    print(kulcs, ertek)