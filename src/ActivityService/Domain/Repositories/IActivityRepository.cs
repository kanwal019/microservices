using System;
using System.Threading.Tasks;

namespace Service.Activity.Domain.Repositories
{
    public interface IActivityRepository
    {
        Task<Models.Activity> GetAsync(Guid id);
        Task AddAsync(Models.Activity activity);
    }
}