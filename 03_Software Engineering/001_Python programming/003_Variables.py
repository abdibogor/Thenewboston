Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> x = 18
>>> x + 15
33
>>> x ** 3
5832
>>> y = 54
>>> x + y
72
>>> g = input("Enter number here: ")
Enter number here: 43
>>> print(g)
43
>>> g + 32
Traceback (most recent call last):
  File "<pyshell#7>", line 1, in <module>
    g + 32
TypeError: can only concatenate str (not "int") to str
>>> g ** 3
Traceback (most recent call last):
  File "<pyshell#8>", line 1, in <module>
    g ** 3
TypeError: unsupported operand type(s) for ** or pow(): 'str' and 'int'
>>> f = input()
