import threading
from queue import Queue
from spider import Spider
from domain import *
from general import *

PROJECT_NAME = 'google'
HOMEPAGE = 'https://www.google.com/'
DOMAIN_NAME = get_domain_name(HOMEPAGE)
QUEUE_FILE = PROJECT_NAME + '/queue.txt'
CRAWLED_FIlE = PROJECT_NAME + '/crawled.txt'
NUMBER_OF_THREADS = 8
queue = Queue()
Spider(PROJECT_NAME, HOMEPAGE, DOMAIN_NAME)

