from PIl import Image

#baby = Image.open("baby.jpg")
#black_white = baby.convert("L")
#black_white.show()

from PIL import ImageFilter
sister = Image.open("sister.jpg")
blur = sister.filter(ImageFilter.BLUR)
detail = sister.filter(ImageFilter.DETAIL)
edges = sister.filter(ImageFilter.FIND_EDGES)

blur.show()
detail.show()
edges.show()