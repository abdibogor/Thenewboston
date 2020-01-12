Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def whatsup(x):
	return 'whats up ' + x

>>> print whatsup('tony')
SyntaxError: invalid syntax
>>> print ( whatsup ( 'tony' ) )
whats up tony
>>> print ( whatsup ('boob' ))
whats up boob
>>> def plusten(y):
	return y+10

>>> print plusten(44)
SyntaxError: invalid syntax
>>> print (plusten(44))
54
>>> 
