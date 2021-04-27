using Library.Common.Events;
using System;
using System.Threading.Tasks;

namespace API.Gateway.Handlers
{
    public class ActivityCreatedHandler : IEventHandler<ActivityCreated>
    {
        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Activity Created: {@event.Name}");
        }
    }
}
