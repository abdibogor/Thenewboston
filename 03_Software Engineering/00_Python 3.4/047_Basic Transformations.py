from PIl import Image

baby = Image.open("baby.jpg")
sqaure_baby = baby.resize((250, 250))
flip_baby = baby.transpose(Image.FLIP_LEFT_RIGHT)
spin_baby = baby.transpose(Image.ROTATE_90)

baby.show()
sqaure_baby.show()
flip_baby.show()
spin_baby.show()