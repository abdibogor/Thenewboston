from PIL import Image

sister = Image.open("habon.jpg")
#r, g, b = sister.split()
#new_img = Image.merge("RGB", (b, g, r))
#new_img.show()
bucky = Image.open("abdi.jpg")
r1, g1, b1 = sister.split()
r2, g2, b2 = sister.split()

new_img = Image.merget("RGB", (r2, g1, b2))
new_img.show()