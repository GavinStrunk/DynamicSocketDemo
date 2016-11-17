
import socket
import netifaces

message = "GET port<EOF>"

def main():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_address = (getHostIp(), 11000)
    print "Connecting to socket..."
    sock.connect(server_address)

    print "Requesting port number..."
    portNumber = requestPortNumber(sock)
    print "Received port %d" % portNumber

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

def requestPortNumber(sock):

    try:
        sock.sendall(message)
        amount_received = 0
        amount_expected = 14

        while amount_received < amount_expected:
            data = sock.recv(14)
            amount_received += len(data)
            print "Response: %s" % data
    finally:
        sock.close()

    return 0

if __name__ == '__main__':
    main()
    pass