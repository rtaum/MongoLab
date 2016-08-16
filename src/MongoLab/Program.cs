using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
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
            var students = mongoClient.GetDatabase("students");
            var sort = new BsonDocument
            {
                { "student_id", 1 },
                { "score", 1 }
            };

            var studentsValue = students.
                GetCollection<Students>("grades").
                Find(s => s.type == "homework").
                Sort(sort).
                ToEnumerable();

            bool skip = true;
            foreach (var s in studentsValue)
            {
                skip = !skip;
                if (skip)
                {
                    continue;
                }

                students.GetCollection<Students>("grades").DeleteOne<Students>(one => one._id == s._id);
            }
        }
    }
}
