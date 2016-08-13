using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
        //hashset skips dublicates
        static void Main(string[] args)
        {
            var myHash = new HashSet<string>();
            myHash.Add("hello");
            myHash.Add("hello");
            Console.WriteLine(myHash.Count);
            string[] s = new string[] { "hello" };
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
