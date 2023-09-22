list = []
szo = input("Adj meg egy szót!")
while szo !="":
    list.append(szo)
    szo = input("Adj meg egy szót!")
min = list[0]
max = list[0]
for elem in list:
    if len(elem) < len(min):
        min = elem
    if len(elem) > len(max):
        max = elem
print(list)
print("A legkisebb: ", min)
print("A legnagyobb: ", max)