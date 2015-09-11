using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    class EventTest
    {

        public delegate void MyEventHandler(object sender, System.EventArgs e);

        public class MyEventCls
        {

            public void MyEventFunc(object sender,System.EventArgs e)
            {
                Console.WriteLine("my event ok");
            }
        }
        private event MyEventHandler myEvent;
        private MyEventCls myEventCls;

        public EventTest()
        {
            myEventCls = new MyEventCls();
            myEvent += new MyEventHandler(myEventCls.MyEventFunc);
        }

        protected void OnMyEvent(System.EventArgs e)
        {
            if(myEvent != null)
            {
                myEvent(this, e);
            }
        }
         public void RaiseEvent()
        {

            EventArgs e = new EventArgs();
            OnMyEvent(e);
        }

        static void Main(string[] args)
        {
            EventTest obj = new EventTest();
            obj.RaiseEvent();
        }
    }
}
