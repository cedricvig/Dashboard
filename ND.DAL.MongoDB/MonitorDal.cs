using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ND.BO;
using MongoDB.Driver.Builders;

namespace ND.DAL.MongoDB
{
    public static class MonitorDal
    {

        static string connectionString = "mongodb://fra-vsd-29328:27017";
        static IMongoClient client = new MongoClient(connectionString);
        static IMongoDatabase database = client.GetDatabase("DEMO");


        public static IList<MonitorResultBO> GetAll()
        {
            IMongoCollection<MonitorResultBO> collection = database.GetCollection<MonitorResultBO>("Monitor");
            IList<MonitorResultBO> result = new List<MonitorResultBO>();
            return collection.Find(new BsonDocument()).ToListAsync().Result;
        }

        public static IList<MonitorResultBO> GetAllPaging(int pageIndex, int pageSize)
        {
            
            var collection = database.GetCollection<MonitorResultBO>("Monitor");

            var sortBy = Builders<MonitorResultBO>.Sort.Descending(m => m.ResultDate);
            var cursor = collection.Find(new BsonDocument()).Sort(sortBy);
            var skipNb = pageIndex * pageSize;

            return cursor.Skip(skipNb).Limit(pageSize).ToListAsync().Result; 
        }

        public static IList<MonitorResultBO> GetByAppAndEnv(string app, string env)
        {
            IMongoCollection<MonitorResultBO> collection = database.GetCollection<MonitorResultBO>("Monitor");
            return collection.Find(d => d.ApplicationCode == app && d.Environment.Code == env).ToListAsync().Result;
        }

        public static IList<StatBO> GetStatsResults(string app, string env)
        {
            IMongoCollection<MonitorResultBO> collection = database.GetCollection<MonitorResultBO>("Monitor");
            return collection.Aggregate()
                .Match(m => m.ApplicationCode == app && m.Environment.Code == env)
                .Group(m => m.Result, g => new StatBO { Result = g.Key, Count = g.Count() })
                .ToListAsync().Result;
        }

        public static async Task<bool> Insert(MonitorResultBO item)
        {
            IMongoCollection<MonitorResultBO> collection = database.GetCollection<MonitorResultBO>("Monitor");
            await collection.InsertOneAsync(item);

            return true;
        }
    }
}
