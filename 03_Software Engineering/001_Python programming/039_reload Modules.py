Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> 
 RESTART: C:\Users\ASUS PC\Documents\Web development\6.Thenewboston\Desktop\1.Python programming\swineflu.py 
>>> import swineflu
>>> swineflu.testmod()
this baby is fat
>>> baby=swineflu.testmod
>>> baby()
this baby is fat
>>> baby()
this baby is fat
>>> import swineflu
>>> swineflu.testmod()
this baby is fat
>>> reload(swineflu)
Traceback (most recent call last):
  File "<pyshell#7>", line 1, in <module>
    reload(swineflu)
NameError: name 'reload' is not defined
>>> swineflu.testmod()
this baby is fat
>>> 
