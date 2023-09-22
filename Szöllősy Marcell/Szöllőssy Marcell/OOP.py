class Személy():
    def __init__(self, nev):
        self.nev = nev

    def bemutatkozik(self):
        print(f'Szia, a nevem {self.nev}', end='')


class Diak(Személy):
    def __init__(self, nev, osztaly):
        super().__init__(nev)
        self.osztaly = osztaly

    def bemutatkozik(self):
        super().bemutatkozik()
        print(f'és a(z) {self.osztaly} osztályába járok.')


class Tanar(Személy):
    def __init__(self, nev, szakok):
        super().__init__(nev)
        self.szakok = szakok

    def bemutatkozik(self):
        super().bemutatkozik()
        print('','-'.join(self.szakok), 'szakos tanár vagyok')

diak01 = Diak('Kiss Péter', '10.A')
tanar01 = Tanar('Horváth Zita', ['biológia', 'kémia'])
tanar02 = Tanar('Schmidt Emil', ['Matematika'])

print(diak01.nev, diak01.osztaly)
diak01.bemutatkozik()
tanar01.bemutatkozik()
tanar02.bemutatkozik()