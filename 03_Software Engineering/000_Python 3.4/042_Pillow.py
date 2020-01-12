form PIL import Image

img = Image.open("A.jpg")
print(img.size)
print(img.format)

img.show()