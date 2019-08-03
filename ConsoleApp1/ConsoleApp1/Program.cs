using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
 
namespace ConsoleApp1
{ 
    public delegate void event1(int a);
    class Program
    {

        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        };
        
        static void Main(string[] args)
        {
            Class2.getInstance().ss();
            Class2.getInstance().read();
            Console.WriteLine("Size of int: {0}", sizeof(int));

            Shape shape = new Rectangle();
            shape.area();
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */

           
            string s1 = "aaaa" ;
            string.Format(s1,"asd");
            string s2 = "aaaa";
            string s3 = "aaaa";


            s3 = string.Concat(s1, s2);
            Books books;
 

            Console.ReadLine();
    }
    }
}
