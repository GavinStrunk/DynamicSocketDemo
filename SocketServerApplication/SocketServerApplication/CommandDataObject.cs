using System;
using System.Text;

namespace SocketServerApplication
{
    class CommandDataObject
    {
        private const int MAXBUFFERSIZE = 1024;

        public String command;
        public String variable;
        public byte[] data = new byte[MAXBUFFERSIZE];
        public StringBuilder stringBuilder = new StringBuilder();
    }
}
