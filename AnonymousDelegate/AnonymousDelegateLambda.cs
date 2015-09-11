//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnonymousDelegate
//{
//    class AnonymousDelegateLambda
//    {
//        delegate void D1();
//        delegate void D2(object param);

//        static void Main(string[] args)
//        {
//            D1 d1 = () => { Console.WriteLine("D1 gh"); };
//            D2 d2 = (object param) => { Console.WriteLine(param); };

//            d1();
//            d2("zhangsan");
//        }

//    }
//}
