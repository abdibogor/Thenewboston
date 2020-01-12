Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> book={'Dad':'Bob','Mom':'Lisa','Bro':'Joe'}
>>> book
{'Dad': 'Bob', 'Mom': 'Lisa', 'Bro': 'Joe'}
>>> book['Dad']
'Bob'
>>> book['Mom']
'Lisa'
>>> ages={'Dad':'42','Mom':'87'}
>>> ages
{'Dad': '42', 'Mom': '87'}
>>> ages['Dad']
'42'
>>> book.clear()
>>> book
{}
>>> tuna=ages.copy()
>>> tuna
{'Dad': '42', 'Mom': '87'}
>>> tuna.has_key('Mom')
Traceback (most recent call last):
  File "<pyshell#11>", line 1, in <module>
    tuna.has_key('Mom')
AttributeError: 'dict' object has no attribute 'has_key'
>>> tuna.has_key('Apples')
Traceback (most recent call last):
  File "<pyshell#12>", line 1, in <module>
    tuna.has_key('Apples')
AttributeError: 'dict' object has no attribute 'has_key'
>>> 
