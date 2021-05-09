using System.Threading.Tasks;

namespace Library.Common.Mongo
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }
}