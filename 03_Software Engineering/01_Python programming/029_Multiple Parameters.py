Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def list(*food):
	print(food)

	
>>> list('apples')
('apples',)
>>> list('apples','peaches','beef')
('apples', 'peaches', 'beef')
>>> def profile(name, *ages):
	print name
	
SyntaxError: Missing parentheses in call to 'print'. Did you mean print(name)?
>>> def profile(name, *ages):
	print(name)
	print(ages)

	
>>> profile('bucky', 42,43,76,54,98)
bucky
(42, 43, 76, 54, 98)
>>> 
