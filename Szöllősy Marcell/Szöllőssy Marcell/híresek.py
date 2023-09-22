class Woman:
    def __init__(self, name, occupation, nationality):
        self.name = name
        self.occupation = occupation
        self.nationality = nationality

women = []
for i in range(3):
    name = input("Enter the name of the woman: ")
    occupation = input("Enter the occupation of the woman: ")
    nationality = input("Enter the nationality of the woman (English or German): ")
    women.append(Woman(name, occupation, nationality))

for woman in women:
    if woman.nationality == "English":
        title = "Ms."
    elif woman.nationality == "German":
        title = "Frau"
    print(title + " " + woman.name + " is a " + woman.occupation)
