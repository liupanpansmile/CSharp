using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAgent
{
    class Agent:IAgent
    {
        private static readonly AgentSingleton singleton = new AgentSingleton();
        private Agent()
        {
            Console.WriteLine("1");
        }
        public static IAgent Instance
        {
            get
            {
                Console.WriteLine("2");
               return singleton.ExistingInstance;   
            }
        }


        private sealed class AgentSingleton : Singleton<IAgent>
        {
            public AgentSingleton():base(null)
            {
                Console.WriteLine("4");
            }


            protected override IAgent CreateInstance()
            {

                Console.WriteLine("5");
                //return new Agent();
                return null;
            }
        }
    }
}
