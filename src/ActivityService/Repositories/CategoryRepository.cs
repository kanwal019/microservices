using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Service.Activity.Domain.Models;
using Service.Activity.Domain.Repositories;

namespace Service.Activity.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMongoDatabase _database;
        
        public CategoryRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task AddAsync(Category category) =>
            await Collection
            .InsertOneAsync(category);

        public async Task<IEnumerable<Category>> BrowseAsync() =>
            await Collection
            .AsQueryable()
            .ToListAsync();    

        public async Task<Category> GetAsync(string name) =>
            await Collection
            .AsQueryable()
            .FirstOrDefaultAsync(category => category.Name == name.ToLowerInvariant());

        private IMongoCollection<Category> Collection => 
            _database.GetCollection<Category>("Categories");
    }
}