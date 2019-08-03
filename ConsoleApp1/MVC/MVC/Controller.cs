using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.MVC
{

    public abstract class Controller
    {
        public abstract void HandleEvent(string eventName, object data = null);
    }
}
