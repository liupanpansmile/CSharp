using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbUsage
{
    class Person
    {
        private string name;
        private int age;
        private string _id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
