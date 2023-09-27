import random
import string

gridsize = int(input("What should the grid size be?"))
print("-----------------")
row = []
line = []

for grid in range(gridsize):
    str(grid)
    line.append(str(grid))

line.append(str(grid + 1))
line.remove(line[0])

for grid in range(gridsize):
    row.append(string.ascii_uppercase[grid])

'''print(line)
print(row)'''

ship = row[random.randint(0, gridsize)] + line[random.randint(0, gridsize)]

#print(ship)

guess = ''
wronguesses = 0
while guess != ship:
    guess = input("Shoot your best")
    if guess != ship:
        wronguesses += 1
        print("MISS")

print("-----------------")
print("It was a hit! The ship was at:", ship)
print("You had:", wronguesses, "misses.")