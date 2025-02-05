from gi.repository import Gtk

class MainWindow(Gtk.Window):

    def __init__(self):
        Gtk.Window.__init_(self, title="Grid Example")

        grid = Gtk.Grid()
        self.add(grid)

    # Create a bunch of buttons
    button1 = Gtk.Button(label="Button 1")
    button2 = Gtk.Button(label="Button 2")
    button3 = Gtk.Button(label="Button 3")
    button4 = Gtk.Button(label="Button 4")
    button5 = Gtk.Button(label="Button 5")
    button6 = Gtk.Button(label="Button 6")

    grid.add(button1)
    grid.attach(button2, 1, 0, 2,  1)
    grid.attach_next_to(button3, button1, Gtk.PositionType.BOTTOM, 1, 2)
    grid.attach_next_to(button4, button3, Gtk.PositionType.RIGHT, 2, 1)
    grid.attach(button5, 1, 2, 1, 1)
    grid_attach_next_to(button6, button3, Gtk.PositionType.RIGHT, 2, 1)

window = MainWindow()
window.connect("delete-event", Gtk.main_quit)
window.show_all()
 Gtk.main()
