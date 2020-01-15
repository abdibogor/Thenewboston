from gi.repository import Gtk

class MainWindow(Gtk.Window):

     def __init__(self):
         Gtk.Window.__init__(self, title="Label Example")
         self.set_border_width(20)
         self.set_default_size(500, 300)

         # Boxes
         hbox = Gtk.Box(spacing=20)
         hbox.set_homogeneous(False)
         vbox_left = Gtk.Box(orientation=Gtk.Orientation.VERTICAL, spacing=20)
         vbox_left.set_homogeneous(False)
         vbox_right = Gtk.Box(orientation=Gtk.Orientation.VERTICAL, spacing=20)
         vbox_right.set_homogeneous(False)

         # Pack the two columns
         hbox.pack_start(vbox_left, True, True, 0)
         hbox.pack_start(vbox_right, True, True, 0)

         # Normal
         label = Gtk.Label("This is a plain label")
         vbox_left.pack_start(label, True, True, 0)

         # Left aligned
         label = Gtk.Label()
         label.set_text("this is left aligned text.\nOh wow mutliple lines soooo cool.")
         label.set_justify(Gtk.Justification.LEFT)
         vbox_left.pack_start(label, True, True, 0)

         # right aligned
         label = Gtk.Label()
         label.set_text("this is right bacon bacon aligned text.\nOh wow mutliple lines soooo cool.")
         label.set_justify(Gtk.Justification.RIGHT)
         vbox_right.pack_start(label, True, True, 0)

         # Line wrap
         label = Gtk.Label("Hi my name is Bucky I love ham. Hi my name is Bucky I love ham.")
         label.set_line_wrap(True)
         vbox.right.pack_start(label, True, True, 0)

         # Fill (newspaper)
         label = Gtk.Label("Hi my name is Bucky I love ham. Hi my name is Bucky I love ham.")
         label.set_line_wrap(True)
         label.set_justify(Gtk.Justification.FILL)
         vbox_right.pack_start(label, True, True, 0)

         # Markup
         label = Gtk.Label()
         label.set_markup("<small> Small text</small>\n"
                        "<big>Big text</big>\n"
                        "<b>I am bold text</b>\n"
                        "<i>Italics is cool too</i>\n"
                        "<a href=\"https://www.google.com\" title=\"Hover text\">Learn stuff</a>\n")
         label.set_line_wrap(True)
         vbox_right.pack_start(label, True, True, 0)
         self.add(hbox)

window = MainWindow()
window.connect("delete-event", Gtk.main_quit)
window.show_all()
Gtk.main()
