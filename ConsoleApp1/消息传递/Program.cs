using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 消息传递
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Messenger.GetSingleton().AddListener(EGameEvent.GameOver,()=>{
                 
                Console.WriteLine("asd");
            });
            Messenger.GetSingleton().AddListener<int>(EGameEvent.GameStart, vale=>
            { 
                Console.WriteLine(vale);
            });
            
            Messenger.GetSingleton().Broadcast(EGameEvent.GameOver);
             Messenger.GetSingleton().Broadcast(EGameEvent.GameStart, 1);

            Console.ReadLine();
        }
    }
}
