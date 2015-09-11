using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new和override区别
{

    class Base
    {

        public int x = 10;
        public virtual void Func()
        {
            Console.WriteLine("Base Func");
        }
    }

    class Derived:Base
    {
        new public int x = 100;
        public override void Func()
        {

            Console.WriteLine("Derived Func");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            Console.WriteLine(d.x);
            d.Func();

            Base b = d;
            Console.WriteLine(b.x);
            b.Func();

        }
    }
}
