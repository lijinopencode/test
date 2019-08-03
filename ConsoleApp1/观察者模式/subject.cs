using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class subject
    {
        List<Observer> observers = new List<Observer>();

        int state {
            get => state;
            set { state = value; notifyAllObservers(); } 
        }
        public void attach(Observer observer)
        {
            observers.Add(observer);
        }
        private void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }

    public abstract class  Observer
    {
        public abstract void update();
    }

    class A : Observer
    {
        public override void update()
        {
            
        }
    }

}
