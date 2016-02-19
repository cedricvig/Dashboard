using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.BO
{
    public class MongoBase
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
