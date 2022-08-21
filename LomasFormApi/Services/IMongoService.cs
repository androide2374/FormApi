using MongoDB.Driver;

namespace LomasFormApi.Services
{
    public interface IMongoService
    {
        IMongoCollection<T> GetCollection<T>(string collectionName);
    }
}
