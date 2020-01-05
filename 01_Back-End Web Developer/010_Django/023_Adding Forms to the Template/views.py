from django.http_import Http404
from django.http import HttpResponse
from django.shortcuts import render, get_object_or_404
from.models import Album

def index(request):
    all_albums = Album.objects.all()
     return render(request, 'music/index.html', context)
	 
def detail(request, album_id):
	   # album = Album.objects.get(pk=album_id)
	   # except Album.DoesNotExist:
	   album = Album.objects.get(Album, pk=album_id)
	   # raise Http404("Album does not exist")
	   return render(request, 'music/index.html', {'album': album}) 