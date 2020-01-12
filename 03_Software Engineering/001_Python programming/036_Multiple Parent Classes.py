Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> class Mom:
	var1='hey im mom'

	
>>> class Dad:
	var2='hey there son im adad'

	
>>> class child(Mom, Dad):
	var3='im a new variable'

	
>>> childObject=child()
>>> childObject.var1
'hey im mom'
>>> childObject.var2
'hey there son im adad'
>>> childObject.var3
'im a new variable'
>>> 
