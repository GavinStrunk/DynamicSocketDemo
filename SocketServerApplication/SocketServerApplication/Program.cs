using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Start Socket Server Application");
            SocketListener.StartListening();
            Console.In.Read();
        }
    }
}
