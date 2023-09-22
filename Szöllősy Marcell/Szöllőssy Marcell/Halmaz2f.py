import random

def generate_numbers():
    numbers = set()
    for i in range(5):
        numbers.add(random.randint(0, 10))
    return numbers

def check_numbers(generated_numbers, guessed_numbers):
    correct = generated_numbers & guessed_numbers
    incorrect = guessed_numbers - generated_numbers
    not_guessed = generated_numbers - guessed_numbers

    print(f"{len(correct)} számot találtál el: {correct}")
    print(f"{len(incorrect)} számot nem találtál el: {incorrect}")
    print(f"{len(generated_numbers)} szám került rögzítésre: {generated_numbers}")
    print(f"{len(not_guessed)} szám nem szerepelt egyik halmazban sem: {not_guessed}")

generated_numbers = generate_numbers()
guessed_numbers = set()
while len(guessed_numbers) < 5:
    number = int(input("Adj meg egy számot [0;10] intervallumon: "))
    if number >= 0 and number <= 10:
        guessed_numbers.add(number)
    else:
        print("Az intervallumon kívüli számot nem tudom rögzíteni.")

check_numbers(generated_numbers, guessed_numbers)
