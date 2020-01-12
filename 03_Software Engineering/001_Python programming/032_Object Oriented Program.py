Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> class exampleClass:
	eyes="blue"
	age=22
	def thisMethod(self):
		return 'hey this method worked'

	
>>> exampleClass
<class '__main__.exampleClass'>
>>> exampleObject=exampleClass()
>>> exampleObject.eyes
'blue'
>>> exampleObject.age
22
>>> exampleObject.thisMethod()
'hey this method worked'
>>> 
