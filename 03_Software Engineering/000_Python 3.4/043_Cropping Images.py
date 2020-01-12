form PIL import Image

img = Image.open("A.jpg")
area = (200,100, 300, 375)
cropped_img = img.crop(area)

img.show()
cropped_img.show()