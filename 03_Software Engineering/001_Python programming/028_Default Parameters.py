Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def name(first,last):
	print("%s %s" % (first,last))

	
>>> name("bucky", "roberts")
bucky roberts
>>> def name(first="tom", last="smith"):
	print("%s %s" % (first,last))

	
>>> name()
tom smith
>>> name("bucky", "roberts")
bucky roberts
>>> name("bucky")
bucky smith
>>> name(last="roberts")
tom roberts
>>> 
