def kerület(x, *plusz, merk=''):

    max = 0

    for szam in plusz:
            max += 1
    if max == 0:
            merk = '0'
    elif max == 1:
            merk = '1'
    elif max == 2:
            merk = '2'
    else:
            merk = '3'

    return merk


print(kerület(1, 2, 3))