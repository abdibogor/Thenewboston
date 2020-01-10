Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> face=[21,18,30]
>>> face
[21, 18, 30]
>>> face.append(45)
>>> face
[21, 18, 30, 45]
>>> apple=['i','love','apples','apples','now']
>>> apple
['i', 'love', 'apples', 'apples', 'now']
>>> apples.count('apples')
Traceback (most recent call last):
  File "<pyshell#6>", line 1, in <module>
    apples.count('apples')
NameError: name 'apples' is not defined
>>> apple.count('apple')
0
>>> apple.count('apples')
2
>>> apple.count('bow')
0
>>> one=[1,2,3]
>>> one
[1, 2, 3]
>>> two=[4,5,6]
>>> two
[4, 5, 6]
>>> one.extend(two)
>>> one
[1, 2, 3, 4, 5, 6]
>>> 
