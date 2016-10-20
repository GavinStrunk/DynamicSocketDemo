
import socket
import netifaces

message = "This is a test<EOF>"

def main():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_address = (getHostIp(), 11000)
    print "Connecting to socket..."
    sock.connect(server_address)

    try:
        print "Sending message..."
        sock.sendall(message)
        amount_received = 0
        amount_expected = len(message)

        while amount_received < amount_expected:
            data = sock.recv(19)
            amount_received += len(data)
            print 'Received: "%s"' % data
    finally:
        print "Closing socket"
        sock.close()

    pass

def getHostIp():
    ipList = []
    interfaceList = netifaces.interfaces()
    for i in interfaceList:
        try:
            ip = netifaces.ifaddresses(i)[netifaces.AF_INET]
            ipList.append(ip[0]['addr'])
        except KeyError:
            pass
        except ValueError:
            pass

    return ipList[0]

if __name__ == '__main__':
    main()
    pass