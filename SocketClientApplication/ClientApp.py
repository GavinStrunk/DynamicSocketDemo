
import socket
import sys

ipAddress = '163.188.55.163'
message = "This is a test<EOF>"

def main():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_address = (ipAddress, 11000)
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

if __name__ == '__main__':
    main()
    pass