using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
      //Queue - first in, first out
        static void Main(string[] args)
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(1);
            myQ.Enqueue(2);
            myQ.Enqueue(3);
            foreach (var q in myQ)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine(myQ.Dequeue());//removes element from the end
            Console.WriteLine(myQ.Peek());// doesnt remove the element
        }
    }
}
