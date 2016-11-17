using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServerApplication
{
    class ConnectionManager
    {
        private Dictionary<int, bool> portList = new Dictionary<int,bool>();
        public ConnectionManager()
        {
            for(int i = 1; i < 11; i++)
            {
                portList.Add(11000 + i, false);

            }
        }

        public void Run()
        {
            while(true)
            {
                Console.WriteLine("Connection Manager is running");
            }
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
