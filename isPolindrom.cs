using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        static bool isPolindrom(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            while (i != j && j - i > 1)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            string word = "abba";
            Console.WriteLine(isPolindrom(word));
            
        }
        
    }
}
