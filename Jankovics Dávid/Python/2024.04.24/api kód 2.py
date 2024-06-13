import requests
from pprint import pprint

URL = 'http://universities.hipolabs.com/search'
payload = {'country': 'hungary', 'name': 'budapest'}

resp = requests.get(URL, params=payload)
egyetemek = resp.json()

for egyetem in egyetemek:
    pprint(egyetem)
print(resp)
