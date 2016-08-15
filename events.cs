using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    public delegate void myEventHandler(string value);

    class EventPublisher
    {
        private string theVal;
        public event myEventHandler valueChanged;
        public string Val
        {
            set
            {
                this.theVal = value;
                this.valueChanged(theVal);
            }
            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();
            obj.valueChanged += objValueChanged;
            string str;
            do
            {
                Console.WriteLine("Enter a value");
                str = Console.ReadLine();
                if (str.Equals("exit"))
                {
                    obj.Val = str;

                }
            } while (!str.Equals("exit"));
               
                Console.WriteLine("Bye");
            
           
        }
        static void objValueChanged(string value)
        {
            Console.WriteLine("the value changed to " + value);
        }
        
    }
}
