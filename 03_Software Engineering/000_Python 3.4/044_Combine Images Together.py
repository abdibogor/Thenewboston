from PIL import Image

sister = Image.open("abdi.jpg")
girl = Image.open("habon.jpg")

area = (100,100,300,300)
sister.paste(girl, area)

sister.show()