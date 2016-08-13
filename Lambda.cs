using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public delegate int Delegate1(int x);
    public delegate void Delegate2(int x, string y);
    public delegate bool Delegate3(int x);

    class Program
    {
      
        static void Main(string[] args)
        {
            Delegate1 foo = (x) => x * x;
            Console.WriteLine("The result is " + foo(5));
            foo = (x) => x * 10;
            Console.WriteLine("The result is " + foo(5));

            Delegate2 bar = (x, y) =>
                Console.WriteLine("{1}, {0}", y, x*10);
            bar(7, "Hello");

            Delegate3 baz = (x) => x > 10;
            Console.WriteLine(baz(8));


        }
    }
}
