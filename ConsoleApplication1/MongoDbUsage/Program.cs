using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace MongoDbUsage
{
    class Program
    {

        /// <summary>
        /// 数据库连接
        /// </summary>
        private const string conn = "mongodb://127.0.0.1:27017";
        /// <summary>
        /// 指定的数据库
        /// </summary>
        private const string dbName = "test";
        /// <summary>
        /// 指定的表
        /// </summary>
        private const string tbName = "person";
      


        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 12;
            p.Name = "lisi";
            p.Id = "1";
            //Add(p);
           // SelectAll();
            Update(p);

        
        }


      
        public static void Add(Person t)
        {
            //创建数据连接
           
            MongoServer server = new MongoClient(conn).GetServer() ;
            //获取指定数据库
            MongoDatabase db = server.GetDatabase(dbName);
            //获取表
            MongoCollection col = db.GetCollection(tbName);
            //插入
            WriteConcernResult result =  col.Insert(t);
            

        }

        
        public static void Delete(string objId)
        {
            //创建数据连接
            MongoServer server = new MongoClient(conn).GetServer();
            //获取指定数据库
            MongoDatabase db = server.GetDatabase(dbName);
            //获取表
            MongoCollection<Person> col = db.GetCollection<Person>(tbName);

            IMongoQuery query = Query.EQ("_id", new ObjectId(objId));

            col.Remove(query);
        }



       
        public static void Update(Person t)
        {
            //创建数据连接
            MongoServer server = new MongoClient(conn).GetServer();
            //获取指定数据库
            MongoDatabase db = server.GetDatabase(dbName);
            //获取表
            MongoCollection<Person> col = db.GetCollection<Person>(tbName);

            BsonDocument bd = BsonExtensionMethods.ToBsonDocument(t);

            IMongoQuery query = Query.EQ("_id", t.Id);

            col.Update(query, new UpdateDocument(bd));

        }


        public static void SelectAll()
        {
            List<Person> list = new List<Person>();

            //创建数据连接
            MongoServer server = new MongoClient(conn).GetServer();
            //获取指定数据库
            MongoDatabase db = server.GetDatabase(dbName);
            //获取表
            MongoCollection<Person> col = db.GetCollection<Person>(tbName);
            //查询全部
            list.AddRange(col.FindAll());

            //--------------------------------
            foreach (Person t in col.FindAll())
            {
                string id = t.Id.ToString();
                string name = t.Name;
                int age = t.Age;
                Console.WriteLine("id={0}, name={1}, age={2}",id,name,age);
            }
        }

    }
}
