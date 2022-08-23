using Domain.Entities;
using MongoDB.Driver;

namespace LomasFormApi.Services
{
  public class MongoService : IMongoService
  {
    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
      var client = new MongoClient("mongodb://192.168.1.99:27017");
      var database = client.GetDatabase("LomasForms");
      var collection = database.GetCollection<T>(collectionName);
      return collection;
    }
  }
}
