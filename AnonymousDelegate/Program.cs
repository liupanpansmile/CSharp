//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnonymousDelegate
//{

//    class Person
//    {
//        public string Id {get;set;}
//        public string Name {get;set;}

//        public override string ToString()
//        {
//            return "Id: " + Id + ", Name: " + Name;
//        }

//    }

//    class Program
//    {
//        delegate void D1();
//        delegate void D2(object param);
//        static void Main(string[] args)
//        {
//            /**
//             *Predicate使用
//            List<Person> list = new List<Person>();
//            list.Add(new Person() { Id = "1001", Name = "zhangsan" });
//            list.Add(new Person() { Id = "1002", Name = "lisi" });
//            list.Add(new Person() { Id = "1003", Name = "wangwu" });

//            Predicate<Person> match = new Predicate<Person>(Match) ;
//            Person p = list.Find(match);
//            if(p != null)
//            {
//                Console.WriteLine(p);
//            }
//             * **/

//            /*
//           D1 d1 = delegate() { Console.WriteLine("D1"); };
//           D2 d2 = delegate(object param) { Console.WriteLine(param); };


//           d1() ;
//           d2("zhangsan");
//            * */
//        }

//        static bool Match(Person p)
//        {
//            return p.Id == "1002" ;
//        }
//    }
//}
