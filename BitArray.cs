using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
      
        static void Main(string[] args)
        {
            BitArray decisions = new BitArray(3);
            decisions[0] = true;
            decisions[1] = false;
            decisions.Set(2, true);

            //or
            bool[] preload = new bool[3] { true, false, true };
            BitArray decisions2 = new BitArray(preload);
            foreach (var d in decisions2)
            {
                Console.WriteLine(d);
            }

        }
    }
}
