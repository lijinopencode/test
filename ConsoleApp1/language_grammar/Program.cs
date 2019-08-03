using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace language_grammar
{
    class A {
        public int counter = 0;
        public int num{
            set;
            get;
        }
        public A()
        {
            num = 1;
            Console.WriteLine("A()");
        }
    }

    class B : A {
        
        //枚举
        [Flags]
        public enum BorderSide : byte
        {
            Left = 1,
            Right = 2

        }

        public int counter = 2;
        public string FUNC(A a)
        {
            int i = a.counter;
            return nameof(this.FUNC);
        }

        int[] sl = new int[100];
        public int this[int s]
        {
            get => 0;
            set => sl[s] = value;
        }

         

        int i { set; get; }
        public delegate void Method1(string name);
        public void Methon2(string name)
        {

        }
        public string s { get => s + s; set => s = value; }
        public string SS
        {
            get { return SS; }
            set { SS = value; }

        }
        //只读
        public decimal AA
        {
            get;
        } = 12;

        public B(decimal aA, int qwe)
        {
            AA = aA;
            this.qwe = qwe;
        }

        public B()
        {
            num = 2;
        }

        //readonly 修饰符防止字段在构造之后被改变
        //readonly 字段只能在声明的时候被赋值，或在构造函数里被赋值

        public readonly int qwe = 1;
    }


    public delegate void Del(string message );
    class Program
    { 
        private static void as操作符()
        {
            B b = new B();
            //构造一个新的 里面的数值复制
            A a = b as A;
            b.FUNC(a);
            Console.WriteLine(a.num);
        }
        private static void   is操作符()
        {
            B b = new B();
            // is 操作符
            bool a = b is A; 
            Console.WriteLine(a);
        }
        private static void  sd(Del del)
        {
            del("ASD");
        }

        private static void 委托lambda(Del del)
        {
            //委托lambda(ng => { }); 形式
        }

        private static void 委托例子( )
        {
            Del del = new Del(delegate (string DE)
            {
                Console.WriteLine(DE);
            });
           

            sd(del);

        }

        static void Main(string[] args)
        {

            as操作符();
            is操作符();
            //MyMethod();

            Console.ReadLine();
        }
    }
}
