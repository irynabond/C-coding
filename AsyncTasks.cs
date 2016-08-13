using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting downloading");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download completed");
            });
           
        }
    }
}
