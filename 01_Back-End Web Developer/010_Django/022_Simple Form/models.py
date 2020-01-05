from django.db import models

class Album(models.Model):
     artist = models.CharField(max_length=250)
	 album_title = models.CharField(max_length=100)
	 album_logo = models.Charfield(max_length=1000)
	 
	 def __str__(self):
	     return self.album_title + ' - ' + self.artist
		 
	class Song(models.Model):
	  album =models.ForeignKey(Album, on_delete=models.CASCADE)
	  file_type = models.CharField(max_length=10)
	  song_title = models.CharField(max_length=250)
	  is_favorite = mdoels.BooleanField(default=False)
	  
	  def__str_(self):
	    return self.song_title
		
		
# python manage.py makemigrations music 
# python manage.py migrate
# 

# Create your models here.
