class Négyzet:
    def __init__(self, oldal):
        self.oldal = oldal

    def terulet(self):
        return self.oldal ** 2

    def kerulet(self):
        return 4 * self.oldal

négyzetek = []

while True:
    oldal = float(input("Kérem adja meg a négyzet oldalhosszát (0 ha nincs több négyzet): "))
    if oldal == 0:
        break
    négyzet = Négyzet(oldal)
    négyzetek.append(négyzet)

print("A megadott négyzetek:")
for négyzet in négyzetek:
    print("- Oldalhossz: ", négyzet.oldal)
    print("- Kerület: ", négyzet.kerulet())
    print("- Terület: ", négyzet.terulet())
