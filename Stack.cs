using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    

    class Program
    {
      //Stack - lasr in, first out
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("Iryna");

            foreach(var s in myStack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(myStack.Pop());//removes the top(last) element
            Console.WriteLine(myStack.Peek()); //doesn't remove the element
        }
    }
}
