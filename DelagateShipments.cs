using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public delegate double CalculateShip(double price);

    class Program
    {
        public static double Zone1(double price)
        {
            return price * 0.25;
        }
        public static double Zone2(double price)
        {
            return price * 0.12 + 25;
        }
        public static double Zone3(double price)
        {
            return price * 0.08;
        }
        public static  double Zone4(double price)
        {
            return price * 0.04 + 25;
        }
        static void Main(string[] args)
        {
            bool question = true;
            double price;
            string z;
            while(question)
            {
                Console.WriteLine("What is your zone?");
                z = Console.ReadLine();
                if (z=="exit")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("What is the price?");
                price = Double.Parse(Console.ReadLine());
                CalculateShip f;
                switch(z)
                {
                    case "zone1":
                        f = Zone1;
                        break;
                    case "zone2":
                        f = Zone2;
                        break;
                    case "zone3":
                        f = Zone3;
                        break;
                    case "zone4":
                        f = Zone4;
                        break;
                    default:
                        f = Zone1;
                        break;
                }
                Console.WriteLine("The fee is " + f(price));
                
            }
        }
    }
}
