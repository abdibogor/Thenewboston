Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> fob=open('C:/Users/ASUS PC/Documents/Web development/6.Thenewboston/Desktop/1.Python programming/a.txt','r')
>>> listme=fob.readlines()
>>> listme
['this is a new line\n', 'this is line 2\n', 'this is third line\n', 'this is the last And final line']
>>> fob.close()
>>> listme[2]="mm i sure love bacon"
>>> listme
['this is a new line\n', 'this is line 2\n', 'mm i sure love bacon', 'this is the last And final line']
>>> fob=open('C:/Users/ASUS PC/Documents/Web development/6.Thenewboston/Desktop/1.Python programming/a.txt','w')
>>> fob.writelines(listme)
>>> fob.close()
>>> mm i sure love bacon\n
