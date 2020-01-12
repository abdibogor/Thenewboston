Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> class parent:
	var1='bacon'
	var2='snausage'

	
>>> class child(parent):
	var2='toast'

	
>>> pob=parent()
>>> cob=child()
>>> pob.var1
'bacon'
>>> pob.var2
'snausage'
>>> cob.var1
'bacon'
>>> cob.var2
'toast'
>>> 
