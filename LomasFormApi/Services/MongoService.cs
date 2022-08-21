using Domain.Entities;
using MongoDB.Driver;

namespace LomasFormApi.Services
{
    public class MongoService : IMongoService
    {
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("LomasForms");
            var collection = database.GetCollection<T>(collectionName);
            return collection;
        }
    }
}
