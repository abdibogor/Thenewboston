from gi.repository import Gtk

class MainWindow(Gtk.Window):

     def __init__(self):
         Gtk.Window.__init__(self, title="Notebook Demo")
         self.set_border_width(10)
         self.notebook = Gtk.Notebook()
         self.add(self.notebook)

         # First page
         self.page1 = Gtk.Box()
         self.page1.set_border_width(10)
         self.page1.add(Gtk.Label('Here is the stuff that is in the main area'))
         self.notebook.append_page(self.page1, Gtk.Label('First Tab'))

         # Second page2
         self.page2 = Gtk.Box()
         self.page2.set_border_width(10)
         self.page2.add(Gtk.Label('Hey there durr I am page two.'))
         icon = Gtk.Image.new_from_icon_name("gnome-dev-cdrom-audio", Gtk.IconSize.MENU)
         self.notebook.append_page(self.page2, icon)


window = MainWindow()
window.connect("delete-event", Gtk.main_quit)
window.show_all()
Gtk.main()
