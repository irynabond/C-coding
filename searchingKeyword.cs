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
            string greet = "I like traveling. My favourite country is Italy.";
            string[] arr = greet.Split(' ');
            Console.WriteLine("Which word should I look for?");
            string key = Console.ReadLine();
            Words(arr, key);
            
            
        }
        public static void Words(string[] greet, string key)
        {
            bool found = false;
            for (int i= 0; i<greet.Length; i++)
            {
                
                if (key==greet[i])
                {
                    Console.WriteLine("Found");
                    found = true;
                }
            }
            if (found==false)
            {
                Console.WriteLine("Not found");
            }

        }
    }








}
