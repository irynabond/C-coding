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
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://irynabond.azurewebsites.net");

            Console.WriteLine("Download complete" + data);

        }
     
    }
}

