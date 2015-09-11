using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionTest
{
    public static class  MethodExtension
    {
        public static  void FuncExtension(this Method method,string param)
        {
            Console.WriteLine("param:" + param);
            
        }
    }
}
