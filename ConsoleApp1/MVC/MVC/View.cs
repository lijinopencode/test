using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.MVC
{
    public abstract class View
    {
        public abstract string Name { get; }

        public List<string> AttationEvent = new List<string>();

        public abstract void HandleEvent(string eventName, object data = null);
    }
}
