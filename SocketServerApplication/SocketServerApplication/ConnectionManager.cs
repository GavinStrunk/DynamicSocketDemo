using System;
using System.Collections.Generic;
using System.Threading;

namespace SocketServerApplication
{
    class ConnectionManager
    {
        private Dictionary<int, bool> portList = new Dictionary<int,bool>();
        private SocketManager socketManager;

        public ConnectionManager()
        {
            for(int i = 1; i < 11; i++)
            {
                portList.Add(11000 + i, false);

            }

            socketManager = new SocketManager(11000);
        }

        public void Run()
        {
            socketManager.Open();

            while(true)
            {
                Console.WriteLine("Connection Manager is running");
                Thread.Sleep(1000);
            }
            socketManager.Close();
        }

        public void AssignPort(int port)
        {
            portList[port] = true;
        }

        public void ReclaimPort(int port)
        {
            portList[port] = false;
        }

        public int FindAvailablePort()
        {
            foreach(KeyValuePair<int,bool> k in portList)
            {
                if(!k.Value)
                {
                    return k.Key;
                }
            }

            return -1;
        }

        public void PrintPortList()
        {
            foreach(KeyValuePair<int, bool> p in portList)
            {
                Console.WriteLine("Port = {0} Used = {1}", p.Key, p.Value);
            }
        }
    }


}
