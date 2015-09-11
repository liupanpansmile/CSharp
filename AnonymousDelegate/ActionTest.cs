using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    class ActionTest
    {
        static Action A1;
        static Action<string> A2;
        static Action<string, string> A3;

        static void Main(string[] args)
        {

            A1 = new Action(Method1);
            A2 = new Action<string>(Method2);
            A3 = new Action<string, string>(Method3);

            A1();
            A2("1");
            A3("1", "2");
        }

        static void Method1()
        {
            Console.WriteLine("Method With No Param");
        }
        static void Method2(string param)
        {
            Console.WriteLine("Method With One Param");
        }
        static void Method3(string param1,string param2)
        {
            Console.WriteLine("Method With Two Params");
        }
    }
}
