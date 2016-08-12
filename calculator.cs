using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   class Program
    {
        static public string value1;
        static string value2;
        static string operation;
        static double res;
        static public int value1Parsed;
        static public int value2Parsed;

        static void Main()
        {
            value1Parsed = GetValues("Enter value 1");
            value2Parsed = GetValues("Enter value 2");
            Console.WriteLine("Choose operation: A - add, B - substruct, C- multiply, D - divide");
            operation = Console.ReadLine();
            GetResult(value1Parsed, value2Parsed, operation);
        }
        static public int GetValues(string value)
        {
            bool result = false;
            int valueParsed;

            while (result == false)
            {

                Console.WriteLine(value);
                string value1 = Console.ReadLine();
                result = Int32.TryParse(value1, out valueParsed);
                if (result == false)
                {
                    continue;
                };
                if (result == true)
                {
                    return valueParsed;
                }
            }
            return 1;
        }

        static public void GetResult(int v1, int v2, string operation)
        {
            switch (operation)
            {
                case "A":
                    res = v1 + v2;
                    break;
                case "B":
                    res = v1 - v2;
                    break;
                case "C":
                    res = v1 * v2;
                    break;
                case "D":
                    res = v1 / v2;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Result is " + res);
        }
    } 
}
