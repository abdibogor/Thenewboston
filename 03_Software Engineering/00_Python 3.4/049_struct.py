from struct import 

# Store as bytes data
packed_data = pack('iif', 6, 19, 4.73)
print(packed_data)

print(calcsize('i'))
print(calcsize('f'))
print(calcsize('iif'))

# To get bytes data back to normal
original_data = unpack('iif')
print(original_data)

print(unpack('iif', b'\*06\*00\*00\*13\*00\*00\*00')\\\*97@'))
