using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }

    };

    class Program
    {

        static void Main()
        {

            Books Book1 = new Books();   /* Declare Book1 of type Book */
           

            /* book 1 specification */
            Book1.getValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);


            /* print Book1 info */
            Book1.display();

          
            Console.ReadKey();

        }
    }
    

}
    


