
import requests
    
resp = requests.get('https://catfact.ninja/facts')
macska_infok = resp.json()
for info in macska_infok['data']:
    print(info['fact'])
    