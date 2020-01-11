Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> class className:
	def createName(self,name):
		self.name=name
	def displayName(self):
		return self.name
	def saying(self):
		print(('hello %s') % self.name)

		
>>> className
<class '__main__.className'>
>>> first=className()
>>> second=className()
>>> first.createName('bucky')
>>> second.createName('tony')
>>> first.displayName()
'bucky'
>>> first.saying()
hello bucky
>>> first.name
'bucky'
>>> 
