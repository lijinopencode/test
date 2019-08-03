using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Singleton<T> where T:class,new()
    {
        private static T _instance;
        private static readonly object syslock = new object();

        public static T getInstance()
        {
            if (_instance == null)
            {
                lock (syslock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                        return _instance;
                    }
                    else
                    {
                        return _instance;
                    }
                }
            }
            else
            {
                return _instance;
            }
        } 
    }

      class A : Singleton<A> {
        public void ss()
        {
            Console.WriteLine("111");
        }
    }
}
