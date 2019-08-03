using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{


    public class MyClass<T > : Singleton<T> where T : class, new()
    { 
    }

    public class MYA : MyClass<MYA>
    {
        public void testfun() {

        }
        public override string ToString()
        {
            return "MYssssA";
        }
    }
    public class Singleton<T> where T : class ,new()
    {
        private static T _instance;
        private static readonly object syslock = new object();
        public static T GetSingleton() {
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
}
