using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAgent
{
    public abstract class Singleton<T>
    {
        private T _instance;

        protected Singleton(T instance)
        {
            Console.WriteLine("3");
            this._instance = instance;
            this._instance = this.CreateInstance();
        }

        protected abstract T CreateInstance();
        public void SetInstance(T instance)
        {
            this._instance = instance;
        }

        public T ExistingInstance
        {
            get
            {
                return this._instance;
            }
        }
    }
}
