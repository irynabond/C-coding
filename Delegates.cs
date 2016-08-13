using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public delegate string MyDelegate(int num1, int num2);

    class Operation
    {
        public string MakeCalc(int num1, int num2)
        {
            return ((num1 + num2) * num1).ToString();
        }
    }
    class Program
    {
        static string func1(int n1, int n2)
        {
            return (n1 + n2).ToString();
        }
        static string func2(int n1, int n2)
        {
            return (n1 * n2).ToString();
        }
        static void Main(string[] args)
        {
            MyDelegate f = func1;
            Console.WriteLine(f(10, 10));
            f = func2;
            Console.WriteLine(f(10, 10));
            Operation oper = new Operation();
            f = oper.MakeCalc;
            Console.WriteLine(f(10, 40));
        }
    }
}
