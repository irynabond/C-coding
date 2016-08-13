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
            var point = new { x = 1, y = 2, z = 3.3457 };
            Console.WriteLine("X {0} Y {1}", point.x, point.y);
            Console.WriteLine($"X {point.x} Y {point.y}");
            Console.WriteLine($"Z {point.z, 8:N2}");

        }  
    }
}

