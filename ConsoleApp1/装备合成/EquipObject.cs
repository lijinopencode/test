using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装备合成
{
    
    //组合模式                                                               
    public class EquipManage
    {
        List<EquipObject> equipObjects = new List<EquipObject>(6);

        public EquipObject GetList(int index) {
            return equipObjects[index];
        }

    }

    public abstract class EquipObject
    {
        
    }

    public abstract class Component {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        } 
        /// <summary>
        /// 增加一个节点
        /// </summary>
        /// <param name="component"></param>
        public abstract void Add(Component component);

        /// <summary>
        /// 移除一个节点
        /// </summary>
        /// <param name="component"></param>
        public abstract void Remove(Component component);

        /// <summary>
        /// 显示层级结构
        /// </summary>
        public abstract void Display(int level);
    }

    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        { }

        /// <summary>
        /// 由于叶子节点没有子节点，所以Add和Remove方法对它来说没有意义，但它继承自Component，这样做可以消除叶节点和枝节点对象在抽象层次的区别，它们具备完全一致的接口。
        /// </summary>
        /// <param name="component"></param>
        public override void Add(Component component)
        {
            Console.WriteLine("Can not add a component to a leaf.");
        }

        /// <summary>
        /// 实现它没有意义，只是提供了一个一致的调用接口
        /// </summary>
        /// <param name="component"></param>
        public override void Remove(Component component)
        {
            Console.WriteLine("Can not remove a component to a leaf.");
        }

        public override void Display(int level)
        {
            Console.WriteLine(new string('-', level) + name);
        }
    }

    public class Composite : Component
    {
        public Composite(string name)
            : base(name)
        { }

        /// <summary>
        /// 一个子对象集合，用来存储其下属的枝节点和叶节点
        /// </summary>
        private List<Component> children = new List<Component>();

        /// <summary>
        /// 增加子节点
        /// </summary>
        /// <param name="component"></param>
        public override void Add(Component component)
        {
            children.Add(component);
        }

        /// <summary>
        /// 移除子节点
        /// </summary>
        /// <param name="component"></param>
        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int level)
        {
            Console.WriteLine(new string('-', level) + name);

            // 遍历其子节点并显示
            foreach (Component component in children)
            {
                component.Display(level + 2);
            }
        }
    }
}
