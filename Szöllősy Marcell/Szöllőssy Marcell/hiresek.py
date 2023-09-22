class HíresNő:
    def __int__(self, név, foglalkozás, nemzetiség):
        self.név = név
        self.foglalkozás = foglalkozás
        self.nemzetiség = nemzetiség
        def előtag(self):
            if self.nemzetiség =='a'
                return 'Ms.'
            else:
                return 'Frau'

híres_nők = []
for _in range(3):
    név = input('Add meg egy híres nő nevét!')
    foglalkozás = input('Add meg a foglalkozását!')
    nemzetiség = input('Add meg a nemzetiségét (a/n)!')
    híres_nő = HíresNő(név, foglalkozás, nemzetiség)
    híres_nők.append(híres_nő)

for híres_nő in híres_nők:
    print(híres_nő.előtag(), híres_nő.név, 'egy híres', híres_nő.foglalkozás)
