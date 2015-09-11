using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionTest
{
    public class Method
    {
        private string priString = "priString";
        protected string proString = "proString";
        public string pubString = "pubString";

        public void Func()
        {
            Console.WriteLine("Method Func");
        }
    }
}
