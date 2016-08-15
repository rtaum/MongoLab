using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mongoClient = new MongoClient();
            var dbList = mongoClient.ListDatabases();
        }
    }
}
