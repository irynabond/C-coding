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
            var produce = new List<Produce>();
            var apple = new Fruit("Apple", 2.2);
            produce.Add(apple);
            var grape = new Fruit("Grape", 3.3);
            produce.Add(grape);
            var beet = new Vegatable("Beet", 3.4);
            produce.Add(beet);
            Console.WriteLine("The total weight is " + Total.GetTotal(produce));
        }
        class Total
        {
            public static double GetTotal (List<Produce> items)
            {
                double result = 0;
                foreach (var product in items)
                {
                    result += product.Weight;
                }
                return result;
            }
        }

        class Produce
        {
            public Produce(string name, double weight)
            {
                Name = name;
                Weight = weight;
            }

            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private double weight;
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }


            public override string ToString()
            {
                return Name + " (" + Weight + "oz) :";
            }
        }
        class Fruit : Produce
        {

            public Fruit(string name, double weight) :
                base(name, weight)
            {

            }

        }
        class Vegatable : Produce
        {
            public Vegatable(string name, double weight) :
                base(name, weight)
            {

            }
        }
    }
}
