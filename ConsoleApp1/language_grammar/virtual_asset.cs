using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C# 继承 样例

namespace language_grammar
{
    
    public class virtual_asset
    {
        public string Name;
        public virtual decimal Liability => 0;
    }
    public interface Iinterface
    {
        int getI(int I);

    }

    public class Stock : virtual_asset, Iinterface
    {
        public static void Testfun()
        {

        }

        //对于接口必须要实现
        int Iinterface.getI(int I) => 0;

        //virtual方法和重写方法的签名、返回类型、可访问程度必须是一样的 
        //重写方法里使用base关键字可以调用父类的实现

        public override decimal Liability
        {
            get
            {
                return base.Liability;
            }
        }
    }
    public  class A11 {
    }

    //一个类只能继承于一个类，但是这个类却可以被多个类继承 下列错误
    /*
    public class Stockerror :A11, virtual_asset, Iinterface
    {
        int Iinterface.getI(int I)
        {
            throw new NotImplementedException();
        }
    }
    */
}
