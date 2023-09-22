import random

def névelő(szó):
    magánhangzók ='aáeéoóöőuúüű'
    if szó[0].lower()in magánhangzók:
        return 'az'
    else:
        return 'a'

def jelző():
    return random.choice(('piros', 'nagy', 'könnyed'))

print('Adj meg három főnevet!')
for szám in range(1,4):
    főnév = input(str(szám)+ 'főnév')
    print(névelő(főnév).capitalize(),'',főnév,'',jelző(),'',sep='')