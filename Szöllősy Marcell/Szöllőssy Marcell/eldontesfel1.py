import random


numbers = []

for i in range(5):
    number = random.randint(1, 7)
    numbers.append(number)

number2 = int(input("Adj meg egy számot!"))

talalat = False
index = 0

while index < len(numbers) and not talalat:
    if numbers[index] == number2:
        talalat = True
    index = index + 1

if talalat:
    print('Van a listában ilyen szám.')
else:
    print('Nincs ilyen szám a listában.')
