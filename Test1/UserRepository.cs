using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace Test1
{
    public class UserRepository
    {
        private IMongoDatabase _db;

        //private readonly string _connectionString = "mongodb://localhost:27017";
        private readonly string _connectionString = "mongodb://kylemongo874591.southafricanorth.azurecontainer.io";
        private readonly string _dbName = "CodeInfinity";

        public UserRepository()
        {
            var client = new MongoClient(_connectionString);
            _db = client.GetDatabase(_dbName);
        }


        //collection _db.GetCollection<User>("")
        // 

        public void Save(User user)
        {
            var collection = _db.GetCollection<User>("Users");
            var filter = Builders<User>.Filter.Eq(nameof(user.IDNumber), user.IDNumber);
            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                collection.InsertOne(user);
            }
            else
            {
                filter = Builders<User>.Filter.Eq(nameof(user.Id), user.Id);
                collection.ReplaceOne(filter, user, new ReplaceOptions { IsUpsert = true });
            }
        }

        public bool IdNumberExists(string idNumber)
        {
            var collection = _db.GetCollection<User>("Users");
            var filter = Builders<User>.Filter.Eq(nameof(User.IDNumber), idNumber);

            return collection.Find(filter).Any();
        }

        public void Get()
        {

        }
    }
}
