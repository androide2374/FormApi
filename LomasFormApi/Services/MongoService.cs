using Domain.Entities;
using MongoDB.Driver;

namespace LomasFormApi.Services
{
  public class MongoService : IMongoService
  {
    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
      var client = new MongoClient("mongodb+srv://androide1169836654:jVY9Gs2khzYc50LR@cluster0.pvrij8t.mongodb.net/?retryWrites=true&w=majority");
      var database = client.GetDatabase("LomasForms");
      var collection = database.GetCollection<T>(collectionName);
      return collection;
    }
  }
}
