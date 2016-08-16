using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoLab
{
    public class Students
    {
        public ObjectId _id { get; set; }
        public int student_id { get; set;  }

        public string type { get; set; }

        public double score { get; set; }
    }
}
