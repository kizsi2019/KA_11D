def mezot_rajzol(x,y):

    for i in range(3):
        for sor in range(6):
            if sor==x and i==y:
                print('+ ', end='')
            else:
                print('o ', end='')
        print()

x = int(input('x'))
y = int(input('y'))
y -= 1
x -= 1
mezot_rajzol(x,y)