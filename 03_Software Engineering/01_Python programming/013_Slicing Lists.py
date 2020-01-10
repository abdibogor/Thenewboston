Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> example=list('easyhoss')
>>> example
['e', 'a', 's', 'y', 'h', 'o', 's', 's']
>>> example[4:]=list('baby')
>>> example
['e', 'a', 's', 'y', 'b', 'a', 'b', 'y']
>>> example[4:]=list('racecars')
>>> example
['e', 'a', 's', 'y', 'r', 'a', 'c', 'e', 'c', 'a', 'r', 's']
>>> example=[7,8,9]
>>> example
[7, 8, 9]
>>> example[1:1]=[3,3,3]
>>> example
[7, 3, 3, 3, 8, 9]
>>> example[1:5]=[]
>>> example
[7, 9]
>>> 
