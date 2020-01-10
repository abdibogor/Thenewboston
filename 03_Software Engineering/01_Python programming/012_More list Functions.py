Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> numbers=[8,1,4,17,28,165,7]
>>> len(numbers)
7
>>> max(numbers)
165
>>> min(numbers)
1
>>> list('abdibogoreh')
['a', 'b', 'd', 'i', 'b', 'o', 'g', 'o', 'r', 'e', 'h']
>>> numbers
[8, 1, 4, 17, 28, 165, 7]
>>> number[3]=77
Traceback (most recent call last):
  File "<pyshell#6>", line 1, in <module>
    number[3]=77
NameError: name 'number' is not defined
>>> numbers[3]=77
>>> numbers
[8, 1, 4, 77, 28, 165, 7]
>>> del numbers[3]
>>> numbers
[8, 1, 4, 28, 165, 7]
>>> 
