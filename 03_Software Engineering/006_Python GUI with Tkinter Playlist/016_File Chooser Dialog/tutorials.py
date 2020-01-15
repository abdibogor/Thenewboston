from gi.repository import Gtk

class MainWindow(Gtk.Window):

  def__init__(self):
  Gtk.Window.__init__(self, title="")
  self.set_border_width(30)
  layout = Gtk.Box(spacing=6)
  self.add(layout)

   button = Gtk.Button("choose File")
   button.connect("clicked", self.on_file_clicked)
   layout.add(button)

   # User clicked the choose file button
   def on_file_clicked(self, widget):

       dialog = Gtk.FileChooserDialog("Select a File Hoss", self, Gtk.FileChooserAction.OPEN,
       ("cancel", Gtk.ResponseType.CANCEL,
        "OK", Gtk.ResponseType.Ok))

       response = dialog.run()

       if response == Gtk.ResponseType.OK;
          print("You clicked the OK button")
          print("File selected" + dialog.get_filename())
     elif response == Gtk.ResponseType.CANCEL:
         print("User didnt choose any file")     

         dialog.destroy()

   window = MainWindow()
   window.connect("delete-event", Gtk.Main_quit)
   window.show_all()
   Gkt.Main()
