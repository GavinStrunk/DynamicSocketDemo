using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SocketServerApplication
{
    class DataStreamer
    {
        public Thread th;
        public DataStreamer(int portNumber)
        {

        }

        ~DataStreamer()
        {
            //@todo reclaim the port
        }

        public static void Run()
        {
            //th = new Thread(Execute);
            //th.Start();
        }

        public static void Stop()
        {

        }

        private static void Execute()
        {
            Console.WriteLine("Running...");
            Thread.Sleep(1000);
        }
    }
}
