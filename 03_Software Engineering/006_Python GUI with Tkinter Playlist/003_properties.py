from gi.repository import Gtk

window = Gtk.Window()

label = Gtk.label()
label.set_label("OMG I think thenewboston is awesome!")
label.set_angle(30)
label.set_halign(Gtk.Align.END)
window.add(label)

print(label.get_properties("angle"))

window.connect("delete-event", Gtk.main_quit)
window.show_all()
Gtk.main()