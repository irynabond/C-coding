using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting downloading");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            Network.Download((message) => Console.WriteLine("Download completed" + message));

        }

        class Network
        {
            public static void Download(Action<String> callback)
            {
                Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    callback("completed");
                });
            } 
        }
     
    }
}

