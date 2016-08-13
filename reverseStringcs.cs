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
            string text = "I love cats";
            string[] textArray = text.Split(' ');
            List<string> listOfWords = new List<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                listOfWords.Add(textArray[i]);
            }
            listOfWords.ToArray();
            string reversed = string.Join(" ", listOfWords.ToArray());
            Console.WriteLine(reversed);

            //char[] arr = text.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine(new string(arr));
        }
    }
}
