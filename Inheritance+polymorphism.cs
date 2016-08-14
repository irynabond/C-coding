using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        abstract class Animal
        {
            private string name;
            private int age;
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
            public string Name
            {
                get { return this.name.ToUpper(); }
                set { this.name = value; }

            }
            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public virtual void MakeNoise()
            {
                Console.WriteLine("I make a noise");
            }

        }
        
        class Dog : Animal
        {
            public Dog(string name, int age) :
                base(name, age)
            {

            }
            public override void MakeNoise()
            {
                Console.WriteLine("I am a litle puppy");
            }
        }
       
        static void Main(string[] args)
        {
            Dog puppy = new Dog("bob", 3);
            Console.WriteLine(puppy.Name);
            puppy.MakeNoise();
            

        }
    }
}

