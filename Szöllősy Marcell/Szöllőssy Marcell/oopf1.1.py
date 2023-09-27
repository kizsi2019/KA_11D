class Négyzet:
    def __init__(self, oldal_hossz):
        self.oldal_hossz = oldal_hossz

    def perimeter(self):
        kerulet = 4 * self.oldal_hossz
        print("A négyzet kerülete:", kerulet)

    def area(self):
        terulet = self.oldal_hossz ** 2
        print("A négyzet területe:", terulet)

négyzet = Négyzet(6)

négyzet.kerulet()
négyzet.terulet()