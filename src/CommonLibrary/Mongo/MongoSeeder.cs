using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Library.Common.Mongo
{
    public class MongoSeeder : IDatabaseSeeder
    {
        protected readonly IMongoDatabase Database;

        public MongoSeeder(IMongoDatabase database)
        {
            Database = database;
        }

        public async Task SeedAsync()
        {
            var collectionCousor = await Database.ListCollectionsAsync();
            var collection = await collectionCousor.ToListAsync();

            if (collection.Any())
            {
                return;
            }
            await CustomSeedAsync();
        }

        protected virtual async Task CustomSeedAsync()
        {
            await Task.CompletedTask;
        }
    }
}