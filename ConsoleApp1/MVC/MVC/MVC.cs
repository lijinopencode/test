using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.MVC
{
    public static class  MVC
    {
        //
        public static Dictionary<string, Model> Models = new Dictionary<string, Model>();

         

        public static Dictionary<string, View> Views = new Dictionary<string, View>();
        public static Dictionary<string, Type> CommandMap = new Dictionary<string, Type>();

        public static void RegisterModel(Model model) {

            Models[model.Name] = model;
        }

        public static void RegisterView(View view) {
            Views[view.Name] = view;
        }

        public static void RegisterController(string eventName,Type type) {
            CommandMap[eventName] = type;
        }

        public static Model GetModel<T>() where T:Model{
            foreach (Model model in Models.Values) {
                if (model is T) {
                    return model;
                }
            }
            return null;
        }

        public static View GetView<T>() where T : View  
        {
            foreach (View view in Views.Values)
            {
                if (view is T)
                {
                    return view;
                }
            }
            return null;
        }

        //发生事件
        public static void SendEvent(string eventName, object data = null) {

            if (CommandMap.ContainsKey(eventName))
            {
                Type t = CommandMap[eventName];
                Controller controller = Activator.CreateInstance(t) as Controller;
                if (controller != null) {
                    controller.HandleEvent(eventName, data);
                }
            }

            foreach (View v in Views.Values) {
                if (v.AttationEvent.Contains(eventName))
                {
                    //相应事件
                    v.HandleEvent(eventName, data);
                }
            }
        }

    }
}
