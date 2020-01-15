from gi.repository import Gtk

# Creates an empty Window
win = Gtk.Window()

# make sure application closes when we press the x button
win.connect("delete-event", Gtk.main_quit)

# displays the Window
win.show_all()

# starts the main loop (breaks when we press x)
Gtk.main()
