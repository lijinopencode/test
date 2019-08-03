using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Ia {
        void read();
        void wwirte();  
    }
    class Class2 : Singleton<Class2>,Ia
    {
        List<string> l;
        Dictionary<int, string> map; 
        HashSet<int> set;  
         
        public void read(){

            Console.WriteLine("void ");
        }
        public void read(int a)
        {
            Console.WriteLine( a);
        }
         
            public void ss()
        {
            Console.WriteLine("111"); 
        }

        public void wwirte()
        {
             
        }
    }
    abstract class Shape
    {
        abstract public int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }
    }
}
