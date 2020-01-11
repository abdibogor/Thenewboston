Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> class parentClass:
	var1='i am var1'
	var2='i am var2'

	
>>> class childClass(parentClass):
	pass

>>> parentObject=parentClass()
>>> parentObject.var1
'i am var1'
>>> childObject=childClass()
>>> childObject.var1
'i am var1'
>>> childObject.var2
'i am var2'
>>> 
