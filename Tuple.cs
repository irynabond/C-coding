using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
      
        static void Main(string[] args)
        {
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(7, "hello", true);
            Console.WriteLine(myTuple.Item3);

            var myTuple2 = Tuple.Create(6, "hello", false);
            Console.WriteLine(myTuple2.Item2);
        }
    }
}
