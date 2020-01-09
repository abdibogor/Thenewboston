from operator import itemgetter 

users = [
    {'fname': 'Bucky', 'lname': 'Roberts'},
    {'fname': 'Tom', 'lname': 'Roberts'},
    {'fname': 'Bernie', 'lname': 'Zunks'},
    {'fname': 'Jenna', 'lname': 'Hayes'},
    {'fname': 'Johnny', 'lname': 'Concrete'},
    {'fname': 'Donald', 'lname': 'Pump'},
    {'fname': 'Ho-Lee', 'lname': 'Fuk'},
    {'fname': 'Busta', 'lname': 'Nut'},
    {'fname': 'Jedediah', 'lname': 'Springfield'},
    {'fname': 'Super', 'lname': 'Mario'}
]

#for x in sorted(users, key=itemgetter('fname'));
#for x in sorted(users, key=itemgetter('lname'));
for x in sorted(users, key=itemgetter('fname'));
print(x)

print('-----')
for x in sorted(users, key=itemgetter('fname', 'lname')):
	print(x)

