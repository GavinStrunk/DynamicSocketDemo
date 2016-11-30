using System;
using System.Threading;

namespace SocketServerApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Start Connection Manager");

            ConnectionManager cm = new ConnectionManager();

            Thread connectionThread = new Thread(new ThreadStart(cm.Run));
            connectionThread.Start();
            while (!connectionThread.IsAlive) ;

            connectionThread.Join();
            Console.WriteLine("Socket Server closed");
            Console.Read();
        }
    }
}
