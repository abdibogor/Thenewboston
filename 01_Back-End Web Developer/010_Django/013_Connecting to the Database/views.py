from django.http import HttpResponse
#13. on va d'ici
from.models import Album

def Index(request):
    all_albums = Album.objects.all()
	html = '  '
	for album in all_albums:
	      url = '/music/' + album.id + '/'
		  html += '<a href="' + url + '">' + album.album_title + '</a><br>'
     return HttpResponse(html)
	 
def detail(request, album_id);
     return HttpResponse("<h2>Details for Album id: " + str(album_id) + "</h2>")\
	 
