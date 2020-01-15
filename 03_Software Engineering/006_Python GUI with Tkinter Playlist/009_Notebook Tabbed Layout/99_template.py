from gi.repository import Gtk

class MainWindow(Gtk.Window):

    def__init__(self):
        Gtk.Window.__init__(self, title="")

window = MainWindow()
window.connect("delete-event", Gtk.main_quit)
window.show_all()
Gtk.main()
