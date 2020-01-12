Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> ages={'dad':42,'mom':48,'lisa':7}
>>> ages
{'dad': 42, 'mom': 48, 'lisa': 7}
>>> for item in ages
SyntaxError: invalid syntax
>>> for item in ages:
	print(item)

	
dad
mom
lisa
>>> for item in ages:
	print(item, ages[item])

	
dad 42
mom 48
lisa 7
>>> while 1:
	name = raw_input('Enter name: ')
	if name == 'quit': break

	
Traceback (most recent call last):
  File "<pyshell#12>", line 2, in <module>
    name = raw_input('Enter name: ')
NameError: name 'raw_input' is not defined
>>> while 1:
	name = 'raw_input'('Enter name: ')
	if name == 'quit': break

	
Traceback (most recent call last):
  File "<pyshell#14>", line 2, in <module>
    name = 'raw_input'('Enter name: ')
TypeError: 'str' object is not callable
>>> 
