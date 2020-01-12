Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> bucky="hey there %s, hows your %s"
>>> varb=('betty', 'foot')
>>> print bucky % varb
SyntaxError: Missing parentheses in call to 'print'. Did you mean print(bucky % varb)?
>>> print(bucky % varb)
hey there betty, hows your foot
>>> varc=('tuna', 'fin')
>>> print (bucky % varc)
hey there tuna, hows your fin
>>> example="Hey now bessie nice chops"
>>> example
'Hey now bessie nice chops'
>>> example.find('bessie')
8
>>> example.find('chops')
20
>>> seperator='hoss'
>>> 
