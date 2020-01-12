import os

# EAch website you crawl is a seperate project (folder)
def create_project_dir(directory):
    if not os.path.exists(directory):
        print('Creating project ' + directory);
        os.makedirs(directory)


create_project_dir('www.google.com');