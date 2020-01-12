Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> fob=open('C:/Users/ASUS PC/Documents/Web development/6.Thenewboston/Desktop/1.Python programming/a.txt','r')
>>> print fob.readline()
SyntaxError: invalid syntax
>>> print(fob.readline())
hey now brown cow
>>> print(fob.readlines())
[]
>>> fob.close()
>>> fob=open('C:/Users/ASUS PC/Documents/Web development/6.Thenewboston/Desktop/1.Python programming/a.txt','w')
>>> fob.write('this is a new line\nthis is line 2\nthis is third line\nthis is the last And final line')
84
>>> fob.close()
>>> 
