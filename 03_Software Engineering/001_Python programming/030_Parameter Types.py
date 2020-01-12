Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def cart(**items):
	print(items)

	
>>> cart(apples=4,peaches=6, beef=60)
{'apples': 4, 'peaches': 6, 'beef': 60}
>>> def profile(first,last,*ages,**items):
	print(first, last)
	print(ages)
	print(items)

	
>>> profile('abdi', 'bogoreh', 32,43,76,65,76, meat=4, saus=64 )
abdi bogoreh
(32, 43, 76, 65, 76)
{'meat': 4, 'saus': 64}
>>> 
