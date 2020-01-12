Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def example(a,b,c):
	return a+b*c

>>> tuna=(5,7,3)
>>> example(*tuna)
26
>>> def example2(**this)
SyntaxError: invalid syntax
>>> def example2(**this):
	print(this)

	
>>> bacon={'mom':32, 'dad':54}
>>> example2(**bacon)
{'mom': 32, 'dad': 54}
>>> 
