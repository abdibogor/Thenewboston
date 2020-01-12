Python 3.7.0 (v3.7.0:1bf9cc5093, Jun 27 2018, 04:59:51) [MSC v.1914 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> players = [29, 58, 66, 71, 87]
>>> players[2]
66
>>> players[2] = 68
>>> players
[29, 58, 68, 71, 87]
>>> players + [90, 91, 98]
[29, 58, 68, 71, 87, 90, 91, 98]
>>> players
[29, 58, 68, 71, 87]
>>> [29, 58, 68, 71, 87]
[29, 58, 68, 71, 87]
>>> players.append(120)
>>> players
[29, 58, 68, 71, 87, 120]
>>> players[:2]
[29, 58]
>>> players[:2] = [0, 0]
>>> players
[0, 0, 68, 71, 87, 120]
>>> players[:2] = []
>>> players
[68, 71, 87, 120]
>>> players[:] = []
>>> players
[]
>>> 
