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
            var beet = new Vegatable("Beet", 3.4);
            produce.Add(beet);
            foreach (var fruit in produce)
            {
                Console.WriteLine(fruit);
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
                base(name, weight) {

            }
        }
    }
}
