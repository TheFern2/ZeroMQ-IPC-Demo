using System;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;

namespace server_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var responder = new ResponseSocket())
            {
                responder.Bind("tcp://*:5555");

                while (true)
                {
                    string str = responder.ReceiveFrameString();
                    Console.WriteLine("Received " + str);
                    Thread.Sleep(1000);  //  Do some 'work'
                    responder.SendFrame("World");
                }
            }
        }
    }
}
